using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using ClosedXML.Excel;
using WebInventar.Models;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace WebInventar.Controllers
{
    public class HomeController : Controller
    {
        string GetHashString(string s)
        {
            //переводим строку в байт-массим  
            byte[] bytes = Encoding.Unicode.GetBytes(s);

            //создаем объект для получения средст шифрования  
            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();

            //вычисляем хеш-представление в байтах  
            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }

        string GenRandomString(string Alphabet, int Length)
        {
            //создаем объект Random, генерирующий случайные числа
            Random rnd = new Random();
            //объект StringBuilder с заранее заданным размером буфера под результирующую строку
            StringBuilder sb = new StringBuilder(Length - 1);
            //переменную для хранения случайной позиции символа из строки Alphabet
            int Position = 0;
            for (int i = 0; i < Length; i++)
            {
                //получаем случайное число от 0 до последнего
                //символа в строке Alphabet
                Position = rnd.Next(0, Alphabet.Length - 1);
                //добавляем выбранный символ в объект
                //StringBuilder
                sb.Append(Alphabet[Position]);
            }
            return sb.ToString();
        }

        string p;
        static int insertid;
        static int updateid;
        private Inventarcontext db;
        static string username;
        static string userid;
        const string SessionName = "_UserId";

        public HomeController(Inventarcontext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Login log)
        {
            if (ModelState.IsValid)
            {
                User user = null;
                p = GetHashString(log.Passwd);
                log.Passwd = p;
                using (db)
                {
                    user = db.Users.FirstOrDefault(u => u.LoginUser == log.LoginUser && u.Passwd == log.Passwd);
                }
                if (user != null)
                {
                    username = user.LoginUser;
                    userid = user.UserId;
                    HttpContext.Session.SetString(SessionName, userid);
                    return RedirectToAction("Desktop", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с таким логином и паролем не найден!");
                }
            }
            return View(log);
        }

        public async Task<IActionResult> Computers()
        {            
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var comp = (from p in db.Computers
                        join Name in db.Workers on p.Name equals Name.Id
                        join Dolg in db.Positions on p.Dolgnost equals Dolg.Id
                        join Cab in db.Cabinets on p.Cab equals Cab.Id
                        join Otdel in db.Otdels on p.Otdel_id equals Otdel.Id
                        join Typec in db.Typecs on p.Type_id equals Typec.Id
                        join Proc in db.Procs on p.Cpu_id equals Proc.Id
                        join Proc_ch in db.Proc_ch on p.Cpu_ch_id equals Proc_ch.Id
                        join Ram_ob in db.Ram_ob on p.Ram_id equals Ram_ob.Id
                        join Hdd_ob in db.Hdd_ob on p.Hdd_id equals Hdd_ob.Id
                        join Monitor_size in db.Monitor_size on p.M_type_id equals Monitor_size.Id
                        join Ups in db.Ups on p.Ups_id equals Ups.Id                        
                        select new CompWithelement
                        {
                            Computer = p,
                            Worker = Name,
                            Position = Dolg,
                            Cabinet = Cab,
                            Otdel = Otdel,
                            Typec = Typec,
                            Proc = Proc,
                            Proc_ch = Proc_ch,
                            Ram_ob = Ram_ob,
                            Hdd_ob = Hdd_ob,
                            Monitor_size = Monitor_size,
                            Ups = Ups
                        });
            return View(await comp.ToListAsync());
        }
        
        /*public async Task<IActionResult> Computers(int page = 1)
        {
            int pageSize = 8;
            var comp = from p in db.Computers
                        select p;
            var count = await comp.CountAsync();
            var items = await comp.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Computers = items
            };
            return View(viewModel);
        }*/

        public async Task<IActionResult> Computer_view(int id)
        {
            var computers = from p in db.Computers
                       select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var comp = (from p in db.Computers
                         join Name in db.Workers on p.Name equals Name.Id
                         join Dolgnost in db.Positions on p.Dolgnost equals Dolgnost.Id
                         join Cab in db.Cabinets on p.Cab equals Cab.Id
                         join Otdel in db.Otdels on p.Otdel_id equals Otdel.Id
                         join Typec in db.Typecs on p.Type_id equals Typec.Id
                         join Proc in db.Procs on p.Cpu_id equals Proc.Id
                         join Proc_ch in db.Proc_ch on p.Cpu_ch_id equals Proc_ch.Id
                         join Ram_ob in db.Ram_ob on p.Ram_id equals Ram_ob.Id
                         join Hdd_ob in db.Hdd_ob on p.Hdd_id equals Hdd_ob.Id
                         join Monitor_size in db.Monitor_size on p.M_type_id equals Monitor_size.Id
                         join Ups in db.Ups on p.Ups_id equals Ups.Id
                         join Ethernet in db.Ethernets on p.Ethernet equals Ethernet.Id
                         join Workgroup in db.Workstations on p.Workgroup equals Workgroup.Id
                         join Internet in db.Changes on p.Internet equals Internet.Id
                         join Ecedo in db.Changes on p.Ecedo equals Ecedo.Id
                         join Rukov_podr in db.Workers on p.Rukov_podr equals Rukov_podr.Id
                         join Rukov_xoz in db.Workers on p.Rukov_xoz equals Rukov_xoz.Id
                         join Passport in db.Workers on p.Passport equals Passport.Id
                        where p.CompID == id
                        select new CompWithelement
                         {
                             Computer = p,
                             Worker = Name,
                             Position = Dolgnost,
                             Cabinet = Cab,
                             Otdel = Otdel,
                             Typec = Typec,
                             Proc = Proc,
                             Proc_ch = Proc_ch,
                             Ram_ob = Ram_ob,
                             Hdd_ob = Hdd_ob,
                             Monitor_size = Monitor_size,
                             Ups = Ups,
                             Ethernet = Ethernet,
                             Workstation = Workgroup,
                             Internet = Internet,
                             Ecedo = Ecedo,
                             Rurov_p = Rukov_podr,
                             Rurov_x = Rukov_xoz,
                             Passport = Passport                             
                        });
            //ViewBag.count = comp.Count();
            //return View(await comp.ToListAsync());
            /*SelectList selectList = new SelectList(db.Otdels, "Id", "Name");
            ViewBag.Otdels = selectList;
            SelectList selectList2 = new SelectList(db.Typecs, "Id", "Name");
            ViewBag.Typecs = selectList2;
            SelectList selectList3 = new SelectList(db.Procs, "Id", "Name");
            ViewBag.Procs = selectList3;
            SelectList selectList4 = new SelectList(db.Proc_ch, "Id", "Name");
            ViewBag.Proc_chs = selectList4;
            SelectList selectList5 = new SelectList(db.Ram_ob, "Id", "Name");
            ViewBag.Ram_obs = selectList5;
            SelectList selectList6 = new SelectList(db.Hdd_ob, "Id", "Name");
            ViewBag.Hdd_obs = selectList6;
            SelectList selectList7 = new SelectList(db.Monitors, "Id", "Name");
            ViewBag.Monitors = selectList7;
            SelectList selectList8 = new SelectList(db.Ups, "Id", "Name");
            ViewBag.Upss = selectList8;
            SelectList selectList9 = new SelectList(db.Monitor_size, "Id", "Name");
            ViewBag.Monitor_sizes = selectList9;
            var comp = (from p in db.Computers
                        where p.CompID == id
                        select p).First();*/
            //return View();
            return View(await comp.ToListAsync());
        }
        
        [HttpGet]
        public IActionResult Computer_edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("NotFoundComponent");
            }
            if (id == 0)
            {
                return RedirectToAction("NotFoundComponent");
            }
            var computers = from p in db.Computers
                       select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            SelectList selectList = new SelectList(db.Otdels, "Id", "Name");
            ViewBag.Otdels = selectList;            
            SelectList selectList2 = new SelectList(db.Typecs, "Id", "Name");
            ViewBag.Typecs = selectList2;            
            SelectList selectList3 = new SelectList(db.Procs, "Id", "Name");
            ViewBag.Procs = selectList3;            
            SelectList selectList4 = new SelectList(db.Proc_ch, "Id", "Name");
            ViewBag.Proc_chs = selectList4;            
            SelectList selectList5 = new SelectList(db.Ram_ob, "Id", "Name");
            ViewBag.Ram_obs = selectList5;            
            SelectList selectList6 = new SelectList(db.Hdd_ob, "Id", "Name");
            ViewBag.Hdd_obs = selectList6;            
            SelectList selectList7 = new SelectList(db.Monitors, "Id", "Name");
            ViewBag.Monitors = selectList7;            
            SelectList selectList8 = new SelectList(db.Ups, "Id", "Name");
            ViewBag.Upss = selectList8;            
            SelectList selectList9 = new SelectList(db.Monitor_size, "Id", "Name");
            ViewBag.Monitor_sizes = selectList9;
            SelectList selectList10 = new SelectList(db.Workers, "Id", "Name");
            ViewBag.Workers = selectList10;
            SelectList selectList11 = new SelectList(db.Positions, "Id", "Name");
            ViewBag.Positions = selectList11;
            SelectList selectList12 = new SelectList(db.Cabinets, "Id", "Name");
            ViewBag.Cabinets = selectList12;
            SelectList selectList13 = new SelectList(db.Ethernets, "Id", "Name");
            ViewBag.Ethernets = selectList13;
            SelectList selectList14 = new SelectList(db.Workstations, "Id", "Name");
            ViewBag.Workstations = selectList14;
            SelectList selectList15 = new SelectList(db.Changes, "Id", "Name");
            ViewBag.Changes = selectList15;
            SelectList selectList16 = new SelectList(db.Workers, "Id", "Name");
            ViewBag.Workers = selectList16;
            /*var comp = (from p in db.Computers
                        join Otdel in db.Otdels on p.Otdel_id equals Otdel.Id
                        join Typec in db.Typecs on p.Type_id equals Typec.Id
                        join Proc in db.Procs on p.Cpu_id equals Proc.Id
                        join Proc_ch in db.Proc_ch on p.Cpu_ch_id equals Proc_ch.Id
                        join Ram_ob in db.Ram_ob on p.Ram_id equals Ram_ob.Id
                        join Hdd_ob in db.Hdd_ob on p.Hdd_id equals Hdd_ob.Id
                        join Monitor_size in db.Monitor_size on p.M_type_id equals Monitor_size.Id
                        join Ups in db.Ups on p.Ups_id equals Ups.Id
                        where p.CompID == id
                        select new CompWithelement
                        {
                            Computer = p,
                            Otdel = Otdel,
                            Typec = Typec,
                            Proc = Proc,
                            Proc_ch = Proc_ch,
                            Ram_ob = Ram_ob,
                            Hdd_ob = Hdd_ob,
                            Monitor_size = Monitor_size,
                            Ups = Ups
                        });*/
            //ViewBag.count = comp.Count();
            var comp = (from p in db.Computers
                        where p.CompID == id
                        select p).First();
            //return View();            
            return View(comp);
        }

        [HttpPost]
        public async Task<IActionResult> Computer_edit(Computer computer)
        {            
            db.Computers.Update(computer);
            await db.SaveChangesAsync();
            updateid = computer.CompID;
            return RedirectToAction("Softwareedit");
        }

        [HttpGet]
        public IActionResult Computer_add()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var work = from p in db.Workers
                       where p.Programmist == true
                       select p;
            SelectList selectList = new SelectList(db.Otdels, "Id", "Name");
            ViewBag.Otdels = selectList;
            SelectList selectList2 = new SelectList(db.Typecs, "Id", "Name");
            ViewBag.Typecs = selectList2;
            SelectList selectList3 = new SelectList(db.Procs, "Id", "Name");
            ViewBag.Procs = selectList3;
            SelectList selectList4 = new SelectList(db.Proc_ch, "Id", "Name");
            ViewBag.Proc_chs = selectList4;
            SelectList selectList5 = new SelectList(db.Ram_ob, "Id", "Name");
            ViewBag.Ram_obs = selectList5;
            SelectList selectList6 = new SelectList(db.Hdd_ob, "Id", "Name");
            ViewBag.Hdd_obs = selectList6;
            SelectList selectList7 = new SelectList(db.Monitors, "Id", "Name");
            ViewBag.Monitors = selectList7;
            SelectList selectList8 = new SelectList(db.Ups, "Id", "Name");
            ViewBag.Upss = selectList8;
            SelectList selectList9 = new SelectList(db.Monitor_size, "Id", "Name");
            ViewBag.Monitor_sizes = selectList9;
            SelectList selectList10 = new SelectList(db.Workers, "Id", "Name");
            ViewBag.Workers = selectList10;
            SelectList selectList11 = new SelectList(db.Positions, "Id", "Name");
            ViewBag.Positions = selectList11;
            SelectList selectList12 = new SelectList(db.Cabinets, "Id", "Name");
            ViewBag.Cabinets = selectList12;
            SelectList selectList13 = new SelectList(db.Ethernets, "Id", "Name");
            ViewBag.Ethernets = selectList13;
            SelectList selectList14 = new SelectList(db.Workstations, "Id", "Name");
            ViewBag.Workstations = selectList14;
            SelectList selectList15 = new SelectList(db.Changes, "Id", "Name");
            ViewBag.Changes = selectList15;
            SelectList selectList16 = new SelectList(db.Workers, "Id", "Name");
            ViewBag.Workers = selectList16;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Computer_add(Computer computer)
        {            
            db.Computers.Add(computer);
            await db.SaveChangesAsync();
            insertid = computer.CompID;
            return RedirectToAction("Softwareadd");
        }

        public async Task<IActionResult> Servers()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var server = (from p in db.Servers
                        join Name_server in db.Server_type on p.Name_server equals Name_server.Id
                        join Otdel in db.Otdels on p.Departament equals Otdel.Id
                        join Fio_admin in db.Workers on p.FIO_admin equals Fio_admin.Id                        
                        select new ServerWithDetail
                        {
                            Server = p,
                            Server_type = Name_server,
                            Otdel = Otdel,
                            Worker = Fio_admin
                        });
            ViewBag.count = server.Count();            
            return View(await server.ToListAsync());
        }

        [HttpGet]
        public IActionResult Serveradd()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var work = from p in db.Workers
                       where p.Programmist == true
                       select p;
            SelectList selectList = new SelectList(db.Server_type, "Id", "Name");
            ViewBag.Server_type = selectList;
            SelectList selectList2 = new SelectList(db.Otdels, "Id", "Name");
            ViewBag.Otdels = selectList2;
            SelectList selectList3 = new SelectList(db.Server_room, "Id", "Name_cab");
            ViewBag.Server_room = selectList3;
            SelectList selectList4 = new SelectList(work, "Id", "Name");
            ViewBag.Workers = selectList4;
            SelectList selectList5 = new SelectList(db.Server_strimer, "Id", "Name");
            ViewBag.Server_strimer = selectList5;
            SelectList selectList6 = new SelectList(db.Server_video, "Id", "Name");
            ViewBag.Server_video = selectList6;
            SelectList selectList7 = new SelectList(db.Server_ethernet, "Id", "Name");
            ViewBag.Server_ethernet = selectList7;
            SelectList selectList8 = new SelectList(db.Server_model, "Id", "Name");
            ViewBag.Server_model = selectList8;
            SelectList selectList9 = new SelectList(db.Server_cpu, "Id", "Name");
            ViewBag.Server_cpu = selectList9;
            SelectList selectList10 = new SelectList(db.Proc_ch, "Id", "Name");
            ViewBag.Proc_ch = selectList10;
            SelectList selectList11 = new SelectList(db.Server_hdd_type, "Id", "Name");
            ViewBag.Server_hdd_type = selectList11;
            SelectList selectList12 = new SelectList(db.Hdd_ob, "Id", "Name");
            ViewBag.Hdd_ob = selectList12;
            SelectList selectList13 = new SelectList(db.Server_dvd, "Id", "Name");
            ViewBag.Server_dvd = selectList13;
            SelectList selectList14 = new SelectList(db.Server_dvd_type, "Id", "Name");
            ViewBag.Server_dvd_type = selectList14;
            SelectList selectList15 = new SelectList(db.Server_dvd_sp, "Id", "Name");
            ViewBag.Server_dvd_sp = selectList15;
            SelectList selectList16 = new SelectList(db.Ram_ob, "Id", "Name");
            ViewBag.Ram_ob = selectList16;
            SelectList selectList17 = new SelectList(db.Server_sound, "Id", "Name");
            ViewBag.Server_sound = selectList17;
            SelectList selectList18 = new SelectList(db.Server_video_type, "Id", "Name");
            ViewBag.Server_video_type = selectList18;
            SelectList selectList19 = new SelectList(db.Monitor_name, "Id", "Name");
            ViewBag.Monitor_name = selectList19;
            SelectList selectList20 = new SelectList(db.Monitor_size, "Id", "Name");
            ViewBag.Monitor_size = selectList20;
            SelectList selectList21 = new SelectList(db.Printer_name, "Id", "Name");
            ViewBag.Printer_name = selectList21;
            SelectList selectList22 = new SelectList(db.Ibps, "Id", "Ibp_name");
            ViewBag.Ibps = selectList22;
            SelectList selectList23 = new SelectList(db.Input_type, "Id", "Name");
            ViewBag.Input_type = selectList23;            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Serveradd(Server server)
        {
            db.Servers.Add(server);
            await db.SaveChangesAsync();
            return RedirectToAction("Servers");
        }

        [HttpGet]
        public IActionResult Serveredit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("NotFoundComponent");
            }
            if (id == 0)
            {
                return RedirectToAction("NotFoundComponent");
            }
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var work = from p in db.Workers
                       where p.Programmist == true
                       select p;
            SelectList selectList = new SelectList(db.Server_type, "Id", "Name");
            ViewBag.Server_type = selectList;
            SelectList selectList2 = new SelectList(db.Otdels, "Id", "Name");
            ViewBag.Otdels = selectList2;
            SelectList selectList3 = new SelectList(db.Server_room, "Id", "Name_cab");
            ViewBag.Server_room = selectList3;
            SelectList selectList4 = new SelectList(work, "Id", "Name");
            ViewBag.Workers = selectList4;
            SelectList selectList5 = new SelectList(db.Server_strimer, "Id", "Name");
            ViewBag.Server_strimer = selectList5;
            SelectList selectList6 = new SelectList(db.Server_video, "Id", "Name");
            ViewBag.Server_video = selectList6;
            SelectList selectList7 = new SelectList(db.Server_ethernet, "Id", "Name");
            ViewBag.Server_ethernet = selectList7;
            SelectList selectList8 = new SelectList(db.Server_model, "Id", "Name");
            ViewBag.Server_model = selectList8;
            SelectList selectList9 = new SelectList(db.Server_cpu, "Id", "Name");
            ViewBag.Server_cpu = selectList9;
            SelectList selectList10 = new SelectList(db.Proc_ch, "Id", "Name");
            ViewBag.Proc_ch = selectList10;
            SelectList selectList11 = new SelectList(db.Server_hdd_type, "Id", "Name");
            ViewBag.Server_hdd_type = selectList11;
            SelectList selectList12 = new SelectList(db.Hdd_ob, "Id", "Name");
            ViewBag.Hdd_ob = selectList12;
            SelectList selectList13 = new SelectList(db.Server_dvd, "Id", "Name");
            ViewBag.Server_dvd = selectList13;
            SelectList selectList14 = new SelectList(db.Server_dvd_type, "Id", "Name");
            ViewBag.Server_dvd_type = selectList14;
            SelectList selectList15 = new SelectList(db.Server_dvd_sp, "Id", "Name");
            ViewBag.Server_dvd_sp = selectList15;
            SelectList selectList16 = new SelectList(db.Ram_ob, "Id", "Name");
            ViewBag.Ram_ob = selectList16;
            SelectList selectList17 = new SelectList(db.Server_sound, "Id", "Name");
            ViewBag.Server_sound = selectList17;
            SelectList selectList18 = new SelectList(db.Server_video_type, "Id", "Name");
            ViewBag.Server_video_type = selectList18;
            SelectList selectList19 = new SelectList(db.Monitor_name, "Id", "Name");
            ViewBag.Monitor_name = selectList19;
            SelectList selectList20 = new SelectList(db.Monitor_size, "Id", "Name");
            ViewBag.Monitor_size = selectList20;
            SelectList selectList21 = new SelectList(db.Printer_name, "Id", "Name");
            ViewBag.Printer_name = selectList21;
            SelectList selectList22 = new SelectList(db.Ibps, "Id", "Ibp_name");
            ViewBag.Ibps = selectList22;
            SelectList selectList23 = new SelectList(db.Input_type, "Id", "Name");
            ViewBag.Input_type = selectList23;
            var server = (from p in db.Servers
                         where p.ServerID == id
                         select p).First();
            return View(server);
        }

        [HttpPost]
        public async Task<IActionResult> Serveredit(Server server)
        {
            db.Servers.Update(server);
            await db.SaveChangesAsync();
            return RedirectToAction("Servers");
        }

        public async Task<IActionResult> ServerView(int id)
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var server = (from p in db.Servers
                          join Name_server in db.Server_type on p.Name_server equals Name_server.Id
                          join Otdel in db.Otdels on p.Departament equals Otdel.Id
                          join Room in db.Server_room on p.Room_id equals Room.Id
                          join Fio_admin in db.Workers on p.FIO_admin equals Fio_admin.Id
                          join Fio_otvet in db.Workers on p.FIO_otvet equals Fio_otvet.Id
                          join Strimer in db.Server_strimer on p.Strimer equals Strimer.Id
                          join Video in db.Server_video on p.Video equals Video.Id
                          join Ethernet in db.Server_ethernet on p.Ethernet equals Ethernet.Id
                          join Fio_mat in db.Workers on p.Fio_mat equals Fio_mat.Id
                          join Fio_rukov in db.Workers on p.Rukov_dep equals Fio_rukov.Id
                          join Model_server in db.Server_model on p.Model_id equals Model_server.Id
                          join Cpu_server in db.Server_cpu on p.Cpu_type_id equals Cpu_server.Id
                          join Cpu_ch_server in db.Proc_ch on p.Cpu_ch_id equals Cpu_ch_server.Id
                          join Hdd_type in db.Server_hdd_type on p.Hdd_type_id equals Hdd_type.Id
                          join Hdd_ob in db.Hdd_ob on p.Hdd_ob_id equals Hdd_ob.Id
                          join Dvd in db.Server_dvd on p.Dvd_id equals Dvd.Id
                          join Dvd_type in db.Server_dvd_type on p.Dvd_type_id equals Dvd_type.Id
                          join Dvd_sp in db.Server_dvd_sp on p.Dvd_sp_id equals Dvd_sp.Id
                          join Ram in db.Ram_ob on p.Ram_id equals Ram.Id
                          join Sound in db.Server_sound on p.Sound_id equals Sound.Id
                          join Video_type in db.Server_video_type on p.Video_type_id equals Video_type.Id
                          join Monitor_model in db.Monitor_name on p.Monitor_model_id equals Monitor_model.Id
                          join Monitor_type in db.Monitor_size on p.Mtype_id equals Monitor_type.Id
                          join Printer_model in db.Printer_name on p.Printer_model_id equals Printer_model.Id
                          join Ibp_name in db.Ibps on p.Ibp_model_id equals Ibp_name.Id
                          join Keyboard in db.Input_type on p.Keyboard_id equals Keyboard.Id
                          join Mouse in db.Input_type on p.Mouse_id equals Mouse.Id
                          where p.ServerID == id
                          select new ServerWithDetail
                          {
                              Server = p,
                              Server_type = Name_server,
                              Otdel = Otdel,
                              Server_room = Room,
                              Worker = Fio_admin,
                              Worker2 = Fio_otvet,
                              Server_strimer = Strimer,
                              Server_video = Video,
                              Server_ethernet = Ethernet,
                              Worker3 = Fio_mat,
                              Worker4 = Fio_rukov,
                              Server_model = Model_server,
                              Server_cpu = Cpu_server,
                              Proc_ch = Cpu_ch_server,
                              Server_hdd_type = Hdd_type,
                              Hdd_ob = Hdd_ob,
                              Server_dvd = Dvd,
                              Server_dvd_type = Dvd_type,
                              Server_dvd_sp = Dvd_sp,
                              Ram_ob = Ram,
                              Server_sound = Sound,
                              Server_video_type = Video_type,
                              Monitor_name = Monitor_model,
                              Monitor_size = Monitor_type,
                              Printer_name = Printer_model,
                              Ibp = Ibp_name,
                              Input_type = Keyboard,
                              Input_type2 = Mouse
                          });
            ViewBag.count = server.Count();
            return View(await server.ToListAsync());
        }

        [HttpGet]
        public List<CompWithelement> GetComputer(string search, out int totalRecord)
        {
            using (db)
            {                
                var poisk = (from p in db.Computers
                             join Cabinet in db.Cabinets on p.Cab equals Cabinet.Id
                             where
                                         Cabinet.Name.Contains(search) ||
                                         p.Sys_inv_m.Contains(search) ||
                                         p.Sys_inv_c.Contains(search) ||
                                         p.Sys_inv_n.Contains(search) ||
                                         p.Sys_inv_p.Contains(search)
                             select new CompWithelement
                             {
                                 Computer = p,
                                 Cabinet = Cabinet
                             });                                  
                    totalRecord = poisk.Count();
                    return poisk.ToList();
                }            
        }

        [HttpGet]
        public IActionResult Computers(string search = "")
        {
            int totalRecord = 0;            
                var data = GetComputer(search, out totalRecord);
                ViewBag.TotalRows = totalRecord;
                ViewBag.search = search;
                return View(data);            
        }

        public async Task<IActionResult> Printers()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var print = (from p in db.Printers
                       join printer_name in db.Printer_name on p.Name_id equals printer_name.Id
                       join printer_type in db.Printer_type on p.Type_id equals printer_type.Id
                       join printer_tex in db.Printer_texnology on p.Tex_id equals printer_tex.Id
                       join printer_format in db.Printer_format on p.Cart_id equals printer_format.Id
                       select new Printerwithcart
                       {
                           Printer = p,
                           Printer_name = printer_name,
                           Printer_type = printer_type,
                           Printer_texnology = printer_tex,
                           Printer_format = printer_format
                       });
            ViewBag.count = print.Count();            
            //var model = print.ToListAsync();            
            return View(await print.ToListAsync());
        }

        [HttpGet]
        public IActionResult Printeredit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("NotFoundComponent");
            }
            if (id == 0)
            {
                return RedirectToAction("NotFoundComponent");
            }
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            SelectList selectList = new SelectList(db.Printer_name, "Id", "Name");
            ViewBag.Printer_name = selectList;
            SelectList selectList2 = new SelectList(db.Printer_type, "Id", "Name");
            ViewBag.Printer_type = selectList2;
            SelectList selectList3 = new SelectList(db.Printer_texnology, "Id", "Name");
            ViewBag.Printer_texnology = selectList3;
            SelectList selectList4 = new SelectList(db.Printer_format, "Id", "Name");
            ViewBag.Printer_format = selectList4;
            SelectList selectList5 = new SelectList(db.Printer_cart, "Id", "Name");
            ViewBag.Printer_cart = selectList5;            
            var print = (from p in db.Printers
                        where p.PrinteriId == id
                        select p).First();
            //return View();            
            return View(print);
        }

        [HttpPost]
        public async Task<IActionResult> Printeredit(Printer printer)
        {
            db.Printers.Update(printer);
            await db.SaveChangesAsync();
            return RedirectToAction("Printers");
        }

        [HttpGet]
        public IActionResult Printersadd()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            SelectList selectList = new SelectList(db.Printer_name, "Id", "Name");
            ViewBag.Printer_name = selectList;
            SelectList selectList2 = new SelectList(db.Printer_type, "Id", "Name");
            ViewBag.Printer_type = selectList2;
            SelectList selectList3 = new SelectList(db.Printer_texnology, "Id", "Name");
            ViewBag.Printer_texnology = selectList3;
            SelectList selectList4 = new SelectList(db.Printer_format, "Id", "Name");
            ViewBag.Printer_format = selectList4;
            SelectList selectList5 = new SelectList(db.Printer_cart, "Id", "Name");
            ViewBag.Printer_cart = selectList5;
            /*var print = (from p in db.Printers
                         where p.PrinteriId == id
                         select p).First();*/
            //return View();            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Printersadd(Printer printer)
        {
            db.Printers.Add(printer);
            await db.SaveChangesAsync();
            return RedirectToAction("Printers");
        }

        public async Task<IActionResult> PrinterView(int id)
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var print = (from p in db.Printers
                         join printer_name in db.Printer_name on p.Name_id equals printer_name.Id
                         join printer_type in db.Printer_type on p.Type_id equals printer_type.Id
                         join printer_tex in db.Printer_texnology on p.Tex_id equals printer_tex.Id
                         join printer_format in db.Printer_format on p.Format_id equals printer_format.Id
                         join printer_cart in db.Printer_cart on p.Cart_id equals printer_cart.Id
                         where p.PrinteriId == id
                         select new Printerwithcart
                         {
                             Printer = p,
                             Printer_name = printer_name,
                             Printer_type = printer_type,
                             Printer_texnology = printer_tex,
                             Printer_format = printer_format,
                             Printer_cart = printer_cart
                         });
            ViewBag.count = print.Count();
            //var model = print.ToListAsync();            
            return View(await print.ToListAsync());
        }

        [HttpGet]
        public List<Printerwithcart> GetPrinter(string search, out int totalRecord)
        {
            using (db)
            {
                /*var poisk = (from a in db.Printers                             
                             where
                                     a.Cab_p.Contains(search) ||                                                                         
                                     a.Sys_inv_p.Contains(search)
                             select a
                              );*/
                var poisk = (from p in db.Printers
                             join printer_name in db.Printer_name on p.Name_id equals printer_name.Id
                             join printer_type in db.Printer_type on p.Type_id equals printer_type.Id
                             join printer_tex in db.Printer_texnology on p.Tex_id equals printer_tex.Id
                             join printer_format in db.Printer_format on p.Format_id equals printer_format.Id
                             join printer_cart in db.Printer_cart on p.Cart_id equals printer_cart.Id
                             where
                             p.Cab_p.Contains(search) ||
                             printer_name.Name.Contains(search) ||
                             p.Sys_inv_p.Contains(search)
                             select new Printerwithcart
                             {
                                 Printer = p,
                                 Printer_name = printer_name,
                                 Printer_type = printer_type,
                                 Printer_texnology = printer_tex,
                                 Printer_format = printer_format,
                                 Printer_cart = printer_cart
                             });
                totalRecord = poisk.Count();
                return poisk.ToList();
            }
        }

        [HttpGet]
        public IActionResult Printers(string search = "")
        {
            int totalRecord = 0;
            var data = GetPrinter(search, out totalRecord);
            ViewBag.count = totalRecord;
            ViewBag.search = search;
            return View(data);
        }

        public async Task<IActionResult> Networks()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var net = (from p in db.Networks
                            join str_pod in db.Otdels on p.Str_pod equals str_pod.Id
                            join fio in db.Workers on p.Fio equals fio.Id
                            join cabinet in db.Cabinets on p.Cabinet equals cabinet.Id
                            join platform in db.Platforms on p.Platform equals platform.Id
                            select new Nets
                            {
                                Network = p,
                                Otdel = str_pod,
                                Worker = fio,
                                Cabinet = cabinet,
                                Platform = platform
                            });
            ViewBag.count = net.Count();
            return View(await net.ToListAsync());
        }

        public async Task<IActionResult> Scaners()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var scaner = from p in db.Scaners
                         select p;
            ViewBag.count = scaner.Count();
            return View(await scaner.ToListAsync());
        }

        public async Task<IActionResult> Risograph()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var riso = from p in db.Risographs
                         select p;
            ViewBag.count = riso.Count();
            return View(await riso.ToListAsync());
        }

        [HttpGet]
        public IActionResult Risograph_edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("NotFoundComponent");
            }
            if (id == 0)
            {
                return RedirectToAction("NotFoundComponent");
            }
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var riso = (from p in db.Risographs
                        where p.Id == id
                        select p).First();
            return View(riso);
        }

        [HttpPost]
        public async Task<IActionResult> Risograph_edit(Risograph risograph)
        {
            db.Risographs.Update(risograph);
            await db.SaveChangesAsync();
            return RedirectToAction("Risograph");
        }

        [HttpGet]
        public IActionResult Risograph_add()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Risograph_add(Risograph risograph)
        {
            db.Risographs.Add(risograph);
            await db.SaveChangesAsync();
            return RedirectToAction("Risograph");
        }

        public async Task<IActionResult> Organization()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var org = from p in db.Organizations
                       select p;            
            return View(await org.ToListAsync());
        }

        [HttpGet]
        public IActionResult Organization_edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("NotFoundComponent");
            }
            if (id == 0)
            {
                return RedirectToAction("NotFoundComponent");
            }
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var org = (from p in db.Organizations
                        where p.Id == id
                        select p).First();
            return View(org);
        }

        [HttpPost]
        public async Task<IActionResult> Organization_edit(Organization org)
        {
            db.Organizations.Update(org);
            await db.SaveChangesAsync();
            return RedirectToAction("Organization");
        }

        public async Task<IActionResult> Antivirus()
        {
            var computers = from p in db.Computers
                       select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var antivirus = from p in db.Antivirus
                       select p;
            ViewBag.count = antivirus.Count();
            return View(await antivirus.ToListAsync());
        }

        public async Task<IActionResult> Browser()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var browser = from p in db.Browsers
                            select p;
            ViewBag.count = browser.Count();
            return View(await browser.ToListAsync());
        }

        [HttpGet]
        public IActionResult Browseradd()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Browseradd(Browser browser)
        {
            db.Browsers.Add(browser);
            await db.SaveChangesAsync();
            return RedirectToAction("Browser");
        }

        public async Task<IActionResult> Component()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var hard = (from p in db.Components
                        join cabinet_name in db.Cabinets on p.Cab equals cabinet_name.Id
                        select new Componentwithelement
                        {
                           Component = p,
                           Cabinet = cabinet_name
                        });            
            ViewBag.count = hard.Count();
            return View(await hard.ToListAsync());
        }
        
        [HttpGet]
        public IActionResult Component_edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("NotFoundComponent");
            }
            if (id == 0)
            {
                return RedirectToAction("NotFoundComponent");
            }
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            SelectList selectList = new SelectList(db.Component_type, "Id", "Name");
            ViewBag.Component_type = selectList;
            SelectList selectList2 = new SelectList(db.Cabinets, "Id", "Name");
            ViewBag.Cabinets = selectList2;
            var comp = (from p in db.Components
                        where p.ComponentiId == id
                        select p).First();         
            return View(comp);
        }

        [HttpPost]
        public async Task<IActionResult> Component_edit(Component component)
        {
            db.Components.Update(component);
            await db.SaveChangesAsync();
            return RedirectToAction("Component");
        }
       
        [HttpGet]
        public IActionResult Component_add()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            SelectList selectList = new SelectList(db.Component_type, "Id", "Name");
            ViewBag.Component_type = selectList;
            SelectList selectList2 = new SelectList(db.Cabinets, "Id", "Name");
            ViewBag.Cabinets = selectList2;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Component_add(Component component)
        {
            db.Components.Add(component);
            await db.SaveChangesAsync();
            return RedirectToAction("Component");
        }

        public async Task<IActionResult> Component_type()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var hard = from p in db.Component_type
                       select p;
            ViewBag.count = hard.Count();
            return View(await hard.ToListAsync());
        }

        [HttpGet]
        public IActionResult Component_type_add(int id)
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Component_type_add(Component_type component)
        {
            db.Component_type.Add(component);
            await db.SaveChangesAsync();
            return RedirectToAction("Component_type");
        }

        [HttpGet]
        public List<Componentwithelement> GetComponent(string search, out int totalRecord)
        {
            using (db)
            {                             
                var poisk = (from p in db.Components
                             join cabinet_name in db.Cabinets on p.Cab equals cabinet_name.Id
                             where
                             p.Hard_name.Contains(search) ||
                             cabinet_name.Name.Contains(search)                             
                             select new Componentwithelement
                             {
                                 Component = p,
                                 Cabinet = cabinet_name
                             });
                totalRecord = poisk.Count();
                return poisk.ToList();
            }
        }

        [HttpGet]
        public IActionResult Component(string search = "")
        {
            int totalRecord = 0;
            var data = GetComponent(search, out totalRecord);
            ViewBag.count = totalRecord;
            ViewBag.search = search;
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> Networksview(int id)
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var net = (from p in db.Networks
                       join str_pod in db.Otdels on p.Str_pod equals str_pod.Id
                       join fio in db.Workers on p.Fio equals fio.Id
                       join cabinet in db.Cabinets on p.Cabinet equals cabinet.Id
                       join platform in db.Platforms on p.Platform equals platform.Id
                       where p.SetiId == id
                       select new Nets
                       {
                           Network = p,
                           Otdel = str_pod,
                           Worker = fio,
                           Cabinet = cabinet,
                           Platform = platform
                       });
            return View(await net.ToListAsync());
        }

        [HttpGet]
        public IActionResult Networksedit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("NotFoundComponent");
            }
            if (id == 0)
            {
                return RedirectToAction("NotFoundComponent");
            }
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            SelectList selectList = new SelectList(db.Network_hard_name, "Id", "Name");
            ViewBag.Network_hard_names = selectList;
            SelectList selectList2= new SelectList(db.Network_hard_type, "Id", "Name");
            ViewBag.Network_hard_types = selectList2;
            SelectList selectList3 = new SelectList(db.Network_hard_port, "Id", "Name");
            ViewBag.Network_hard_ports = selectList3;
            SelectList selectList4 = new SelectList(db.Otdels, "Id", "Name");
            ViewBag.Otdels = selectList4;
            SelectList selectList5 = new SelectList(db.Workers, "Id", "Name");
            ViewBag.Workers = selectList5;
            SelectList selectList6 = new SelectList(db.Cabinets, "Id", "Name");
            ViewBag.Cabinets = selectList6;
            SelectList selectList7 = new SelectList(db.Platforms, "Id", "Name");
            ViewBag.Platforms = selectList7;
            var comp = (from p in db.Networks
                        where p.SetiId == id
                        select p).First();
            return View(comp);
        }

        [HttpPost]
        public async Task<IActionResult> Networksedit(Network network)
        {
            db.Networks.Update(network);
            await db.SaveChangesAsync();
            return RedirectToAction("Networks");
        }

        [HttpGet]
        public IActionResult Networksadd()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            SelectList selectList = new SelectList(db.Network_hard_name, "Id", "Name");
            ViewBag.Network_hard_names = selectList;
            SelectList selectList2 = new SelectList(db.Network_hard_type, "Id", "Name");
            ViewBag.Network_hard_types = selectList2;
            SelectList selectList3 = new SelectList(db.Network_hard_port, "Id", "Name");
            ViewBag.Network_hard_ports = selectList3;
            SelectList selectList4 = new SelectList(db.Otdels, "Id", "Name");
            ViewBag.Otdels = selectList4;
            SelectList selectList5 = new SelectList(db.Workers, "Id", "Name");
            ViewBag.Workers = selectList5;
            SelectList selectList6 = new SelectList(db.Cabinets, "Id", "Name");
            ViewBag.Cabinets = selectList6;
            SelectList selectList7 = new SelectList(db.Platforms, "Id", "Name");
            ViewBag.Platforms = selectList7;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Networksadd(Network network)
        {
            //if (ModelState.IsValid) {
            if (string.IsNullOrEmpty(network.Activ_inv))
            {
                ModelState.AddModelError(nameof(network.Activ_inv), "Введите инвентарный номер");                                    
            }            
                db.Networks.Add(network);
                await db.SaveChangesAsync();
                return RedirectToAction("Networks");                                                
            //}
            //if (string.IsNullOrEmpty(network.Activ_inv))
            //{
            //    ModelState.AddModelError("Activ_inv", "Инв.номер");                                    
            //}
            //return View();
        }

        public async Task<IActionResult> Network_hard_name()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var hard = from p in db.Network_hard_name
                       select p;
            ViewBag.count = hard.Count();
            return View(await hard.ToListAsync());
        }

        [HttpGet]
        public IActionResult Network_hard_name_add()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Network_hard_name_add(Network_hard_name network)
        {
            db.Network_hard_name.Add(network);
            await db.SaveChangesAsync();
            return RedirectToAction("Network_hard_name");
        }

        public async Task<IActionResult> Network_hard_type()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var hard = from p in db.Network_hard_type
                       select p;
            ViewBag.count = hard.Count();
            return View(await hard.ToListAsync());
        }

        [HttpGet]
        public IActionResult Network_hard_type_add()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Network_hard_type_add(Network_hard_type network)
        {
            db.Network_hard_type.Add(network);
            await db.SaveChangesAsync();
            return RedirectToAction("Network_hard_type");
        }

        public async Task<IActionResult> Printer_type()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var printer = from p in db.Printer_cart
                       select p;
            ViewBag.count = printer.Count();
            return View(await printer.ToListAsync());
        }

        [HttpGet]
        public IActionResult Printer_type_add()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Printer_type_add(Printer_cart printer)
        { 
            db.Printer_cart.Add(printer);
            await db.SaveChangesAsync();
            return RedirectToAction("Printer_type");
        }

        public async Task<IActionResult> Printer_name()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var print = from p in db.Printer_name
                      select p;
            return View(await print.ToListAsync());
        }        

        [HttpGet]
        public IActionResult Ibp_edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("NotFoundComponent");
            }
            if (id == 0)
            {
                return RedirectToAction("NotFoundComponent");
            }
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var ibp = (from p in db.Ibps
                        where p.Id == id
                        select p).First();
            return View(ibp);
        }

        [HttpPost]
        public async Task<IActionResult> Ibp_edit(Ibp ibp)
        {
            db.Ibps.Update(ibp);
            await db.SaveChangesAsync();
            return RedirectToAction("Ibp");
        }

        [HttpGet]
        public IActionResult Ibp_add()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Ibp_add(Ibp ibp)
        {
            db.Ibps.Add(ibp);
            await db.SaveChangesAsync();
            return RedirectToAction("Ibp");
        }

        [HttpGet]
        public IActionResult Scaner_edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("NotFoundComponent");
            }
            if (id == 0)
            {
                return RedirectToAction("NotFoundComponent");
            }
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var scan = (from p in db.Scaners
                       where p.Id == id
                       select p).First();
            return View(scan);
        }

        [HttpPost]
        public async Task<IActionResult> Scaner_edit(Scaner scan)
        {
            db.Scaners.Update(scan);
            await db.SaveChangesAsync();
            return RedirectToAction("Scaners");
        }

        [HttpGet]
        public IActionResult Scaner_add()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var model = new Scaner();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Scaner_add(Scaner scan)
        {
            db.Scaners.Add(scan);
            await db.SaveChangesAsync();
            return RedirectToAction("Scaners");
        }

        [HttpGet]
        public IActionResult Softwareadd()
        {
            SelectList selectList = new SelectList(db.Changes, "Id", "Name");
            ViewBag.Changes = selectList;                        
            SelectList selectList3 = new SelectList(db.Os, "Id", "Name");
            ViewBag.Os = selectList3;
            SelectList selectList4 = new SelectList(db.Offices, "Id", "Name");
            ViewBag.Offices = selectList4;
            SelectList selectList5 = new SelectList(db.Antivirus, "Id", "Name");
            ViewBag.Antivirus = selectList5;
            SelectList selectList6 = new SelectList(db.Grafics, "Id", "Name");
            ViewBag.Grafics = selectList6;
            SelectList selectList7 = new SelectList(db.Browsers, "Id", "Name");
            ViewBag.Browsers = selectList7;
            SelectList selectList8 = new SelectList(db.Arhivators, "Id", "Name");
            ViewBag.Arhivators = selectList8;
            SelectList selectList9 = new SelectList(db.Buxgalters, "Id", "Name");
            ViewBag.Buxgalters = selectList9;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Softwareadd(Programm programm)
        {
            programm.CompId = insertid;
            db.Programms.Add(programm);
            await db.SaveChangesAsync();
            return RedirectToAction("Computers");
        }

        [HttpGet]
        public IActionResult Softwareedit()
        {
            SelectList selectList = new SelectList(db.Changes, "Id", "Name");
            ViewBag.Changes = selectList;
            SelectList selectList3 = new SelectList(db.Os, "Id", "Name");
            ViewBag.Os = selectList3;
            SelectList selectList4 = new SelectList(db.Offices, "Id", "Name");
            ViewBag.Offices = selectList4;
            SelectList selectList5 = new SelectList(db.Antivirus, "Id", "Name");
            ViewBag.Antivirus = selectList5;
            SelectList selectList6 = new SelectList(db.Grafics, "Id", "Name");
            ViewBag.Grafics = selectList6;
            SelectList selectList7 = new SelectList(db.Browsers, "Id", "Name");
            ViewBag.Browsers = selectList7;
            SelectList selectList8 = new SelectList(db.Arhivators, "Id", "Name");
            ViewBag.Arhivators = selectList8;
            SelectList selectList9 = new SelectList(db.Buxgalters, "Id", "Name");
            ViewBag.Buxgalters = selectList9;            
            var soft = (from p in db.Programms
                        where p.CompId == updateid
                        select p).First();                        
            return View(soft);
        }

        [HttpPost]
        public async Task<IActionResult> Softwareedit(Programm programm)
        {
            programm.CompId = updateid;
            db.Programms.Update(programm);
            await db.SaveChangesAsync();            
            return RedirectToAction("Computers");
        }

        public async Task<IActionResult> Office()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var office = from p in db.Offices
                       select p;
            ViewBag.count = office.Count();
            return View(await office.ToListAsync());
        }

        public IActionResult Officeadd()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Officeadd(Office office)
        {
            db.Offices.Add(office);
            await db.SaveChangesAsync();
            return RedirectToAction("Office");
        }

        public async Task<IActionResult> Os()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var os = from p in db.Os
                         select p;
            ViewBag.count = os.Count();
            return View(await os.ToListAsync());
        }

        public IActionResult Osadd()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Osadd(Os os)
        {
            db.Os.Add(os);
            await db.SaveChangesAsync();
            return RedirectToAction("Os");
        }

        public async Task<IActionResult> Otdel()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var otdel = from p in db.Otdels
                     select p;
            ViewBag.count = otdel.Count();
            return View(await otdel.ToListAsync());
        }
        
        [HttpGet]
        public IActionResult Otdeledit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("NotFoundComponent");
            }
            if (id == 0)
            {
                return RedirectToAction("NotFoundComponent");
            }
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var otd = (from p in db.Otdels
                       where p.Id == id
                       select p).First();
            return View(otd);
        }

        [HttpPost]
        public async Task<IActionResult> Otdeledit(Otdel otd)
        {
            db.Otdels.Update(otd);
            await db.SaveChangesAsync();
            return RedirectToAction("Otdel");
        }

        public IActionResult Otdeladd()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Otdeladd(Otdel otd)
        {
            db.Otdels.Add(otd);
            await db.SaveChangesAsync();
            return RedirectToAction("Otdel");
        }

        public async Task<IActionResult> Cabinet()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var cab = from p in db.Cabinets
                        select p;
            ViewBag.count = cab.Count();
            return View(await cab.ToListAsync());
        }

        public IActionResult Cabinetadd()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cabinetadd(Cabinet cab)
        {
            db.Cabinets.Add(cab);
            await db.SaveChangesAsync();
            return RedirectToAction("Cabinet");
        }

        public async Task<IActionResult> Position()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var position = from p in db.Positions
                        select p;
            ViewBag.count = position.Count();
            return View(await position.ToListAsync());
        }

        public IActionResult Positionadd()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Positionadd(Position position)
        {
            db.Positions.Add(position);
            await db.SaveChangesAsync();
            return RedirectToAction("Postition");
        }

        public async Task<IActionResult> Proc()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var proc = from p in db.Procs
                        select p;
            ViewBag.count = proc.Count();
            return View(await proc.ToListAsync());
        }

        public IActionResult Procadd()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Procnadd(Proc proc)
        {
            db.Procs.Add(proc);
            await db.SaveChangesAsync();
            return RedirectToAction("Proc");
        }

        public async Task<IActionResult> Proc_ch()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var proc = from p in db.Proc_ch
                        select p;
            ViewBag.count = proc.Count();
            return View(await proc.ToListAsync());
        }

        public IActionResult Proc_ch_add()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Proc_ch_add(Proc_ch proc)
        {
            db.Proc_ch.Add(proc);
            await db.SaveChangesAsync();
            return RedirectToAction("Proc_ch");
        }

        public async Task<IActionResult> Ram()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var ram = from p in db.Ram_ob
                       select p;
            ViewBag.count = ram.Count();
            return View(await ram.ToListAsync());
        }

        public IActionResult Ramadd()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Ramadd(Ram_ob ram)
        {
            db.Ram_ob.Add(ram);
            await db.SaveChangesAsync();
            return RedirectToAction("Ram");
        }

        public async Task<IActionResult> Hdd()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var hdd = from p in db.Hdd_ob
                      select p;
            ViewBag.count = hdd.Count();
            return View(await hdd.ToListAsync());
        }

        public IActionResult HDDadd()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> HDDadd(Hdd_ob hdd)
        {
            db.Hdd_ob.Add(hdd);
            await db.SaveChangesAsync();
            return RedirectToAction("Hdd");
        }

        public async Task<IActionResult> Worker()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var work = from p in db.Workers
                      select p;
            ViewBag.count = work.Count();
            return View(await work.ToListAsync());
        }

        public IActionResult Workeradd()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Workeradd(Worker work)
        {
            db.Workers.Add(work);
            await db.SaveChangesAsync();
            return RedirectToAction("Worker");
        }

        [HttpGet]
        public IActionResult Workeredit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("NotFoundComponent");
            }
            if (id == 0)
            {
                return RedirectToAction("NotFoundComponent");
            }
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var work = (from p in db.Workers
                       where p.Id == id
                       select p).First();
            return View(work);
        }

        [HttpPost]
        public async Task<IActionResult> Workeredit(Worker work)
        {
            db.Workers.Update(work);
            await db.SaveChangesAsync();
            return RedirectToAction("Worker");
        }

        [HttpGet]
        public List<Worker> GetWorker(string search, out int totalRecord)
        {
            using (db)
            {
                var poisk = (from p in db.Workers
                             where
                             p.Name.Contains(search)
                             select p);
                totalRecord = poisk.Count();
                return poisk.ToList();
            }
        }

        [HttpGet]
        public IActionResult Worker(string search = "")
        {
            int totalRecord = 0;
            var data = GetWorker(search, out totalRecord);
            ViewBag.count = totalRecord;
            ViewBag.search = search;
            return View(data);
        }

        public async Task<IActionResult> Workstation()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var work = from p in db.Workstations
                      select p;
            ViewBag.count = work.Count();
            return View(await work.ToListAsync());
        }

        public IActionResult Workstationadd()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Workstationadd(Workstation work)
        {
            db.Workstations.Add(work);
            await db.SaveChangesAsync();
            return RedirectToAction("Workstation");
        }

        public async Task<IActionResult> Proectors()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var proect = from p in db.Proectors
                       select p;
            ViewBag.count = proect.Count();
            return View(await proect.ToListAsync());
        }

        public async Task<IActionResult> Ibp()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var ibp = from p in db.Ibps
                       select p;
            ViewBag.count = ibp.Count();
            return View(await ibp.ToListAsync());
        }

        public async Task<IActionResult> Server_room()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var work = from p in db.Server_room
                       select p;
            ViewBag.count = work.Count();
            return View(await work.ToListAsync());
        }

        public IActionResult Server_room_add()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Server_room_add(Server_room room)
        {
            db.Server_room.Add(room);
            await db.SaveChangesAsync();
            return RedirectToAction("Server_room");
        }

        public async Task<IActionResult> Diagnostic_comp()
        {
            var diagnost = (from p in db.Diagnostic_c
                         join org_name in db.Organizations on p.Name_org equals org_name.Id
                         join diagost_name in db.Name_d_spr on p.Name_d equals diagost_name.Id
                         join type_d in db.Devices on p.Type_d equals type_d.Id
                         join cab_d in db.Cabinets on p.Cab_d equals cab_d.Id
                         join reason_p in db.Reason_p_spr on p.Reason_p equals reason_p.Id
                         join reason_r in db.Reason_r_spr on p.Reason_r equals reason_r.Id
                         join engineer_r in db.Workers on p.Engineer_r equals engineer_r.Id
                         join director_r in db.Workers on p.Director_r equals director_r.Id
                            where p.Type_d == 1
                            select new Diagnostic
                            {
                             Diagnostic_c = p,
                             Organization = org_name,
                             Name_d_spr = diagost_name,
                             Devices = type_d,
                             Cabinet = cab_d,
                             Reason_p_spr = reason_p,
                             Reason_r_spr = reason_r,
                             Worker = engineer_r,
                             Worker2 = director_r
                            });
            return View(await diagnost.ToListAsync());
        }

        public async Task<IActionResult> Diagnostic_print()
        {
            var diagnost = (from p in db.Diagnostic_c
                            join org_name in db.Organizations on p.Name_org equals org_name.Id
                            join diagost_name in db.Name_d_spr on p.Name_d equals diagost_name.Id
                            join type_d in db.Devices on p.Type_d equals type_d.Id
                            join cab_d in db.Cabinets on p.Cab_d equals cab_d.Id
                            join reason_p in db.Reason_p_spr on p.Reason_p equals reason_p.Id
                            join reason_r in db.Reason_r_spr on p.Reason_r equals reason_r.Id
                            join engineer_r in db.Workers on p.Engineer_r equals engineer_r.Id
                            join director_r in db.Workers on p.Director_r equals director_r.Id
                            where p.Type_d == 6
                            select new Diagnostic
                            {
                                Diagnostic_c = p,
                                Organization = org_name,
                                Name_d_spr = diagost_name,
                                Devices = type_d,
                                Cabinet = cab_d,
                                Reason_p_spr = reason_p,
                                Reason_r_spr = reason_r,
                                Worker = engineer_r,
                                Worker2 = director_r
                            });
            return View(await diagnost.ToListAsync());
        }

        [HttpGet]
        public IActionResult Diagnosticadd()
        {
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var work = from p in db.Workers
                       where p.Programmist == true
                       select p;
            SelectList selectList = new SelectList(db.Organizations, "Id", "Name_org");
            ViewBag.Organizations = selectList;
            SelectList selectList2 = new SelectList(db.Name_d_spr, "Id", "Name");
            ViewBag.Name_d_spr = selectList2;
            SelectList selectList3 = new SelectList(db.Devices, "Id", "Name");
            ViewBag.Devices = selectList3;
            SelectList selectList4 = new SelectList(db.Cabinets, "Id", "Name");
            ViewBag.Cabinets = selectList4;
            SelectList selectList5 = new SelectList(db.Reason_p_spr, "Id", "Name");
            ViewBag.Reason_p_spr = selectList5;
            SelectList selectList6 = new SelectList(db.Reason_r_spr, "Id", "Name");
            ViewBag.Reason_r_spr = selectList6;
            SelectList selectList7 = new SelectList(work, "Id", "Name");
            ViewBag.Workers = selectList7;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Diagnosticadd(Diagnostic_c diagnost)
        {
            db.Diagnostic_c.Add(diagnost);
            await db.SaveChangesAsync();
            return RedirectToAction("Diagnostic_comp");
        }

        [HttpGet]
        public IActionResult Diagnosticedit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("NotFoundComponent");
            }
            if (id == 0)
            {
                return RedirectToAction("NotFoundComponent");
            }
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();
            var work = from p in db.Workers
                       where p.Programmist == true
                       select p;
            SelectList selectList = new SelectList(db.Organizations, "Id", "Name_org");
            ViewBag.Organizations = selectList;
            SelectList selectList2 = new SelectList(db.Name_d_spr, "Id", "Name");
            ViewBag.Name_d_spr = selectList2;
            SelectList selectList3 = new SelectList(db.Devices, "Id", "Name");
            ViewBag.Devices = selectList3;
            SelectList selectList4 = new SelectList(db.Cabinets, "Id", "Name");
            ViewBag.Cabinets = selectList4;
            SelectList selectList5 = new SelectList(db.Reason_p_spr, "Id", "Name");
            ViewBag.Reason_p_spr = selectList5;
            SelectList selectList6 = new SelectList(db.Reason_r_spr, "Id", "Name");
            ViewBag.Reason_r_spr = selectList6;
            SelectList selectList7 = new SelectList(work, "Id", "Name");
            ViewBag.Workers = selectList7;            
            var comp = (from p in db.Diagnostic_c
                        where p.Id == id
                        select p).First();
            return View(comp);
        }

        [HttpPost]
        public async Task<IActionResult> Diagnosticedit(Diagnostic_c diagnost)
        {
            db.Diagnostic_c.Update(diagnost);
            await db.SaveChangesAsync();
            return RedirectToAction("Diagnostic_comp");
        }
        
        public IActionResult Desktop()
        {            
            ViewBag.user = username;
            var computers = from p in db.Computers
                        select p;
            ViewBag.compcount = computers.Count();
            var nout = from p in db.Computers
                       where p.Type_id == 2
                       select p;
            ViewBag.noutcount = nout.Count();
            var printers = from p in db.Printers
                       select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                           select p;
            ViewBag.componentcount = components.Count();
            ViewBag.UserId = HttpContext.Session.GetString(SessionName);
            return View();
        }

        public async Task<IActionResult> Repair()
        {
            var repair = (from p in db.Repair
                            join cab_name in db.Cabinets on p.Cab equals cab_name.Id
                            join device_name in db.Devices on p.Device equals device_name.Id
                            join result in db.Result on p.Result equals result.Id                            
                            select new Repairs
                            {
                                Repair = p,
                                Cabinet = cab_name,
                                Devices = device_name,
                                Result = result                                
                            });
            return View(await repair.ToListAsync());
        }

        [HttpGet]
        public IActionResult Repair_add()
        {
            SelectList selectList = new SelectList(db.Cabinets, "Id", "Name");
            ViewBag.Cabinets = selectList;
            SelectList selectList2 = new SelectList(db.Devices, "Id", "Name");
            ViewBag.Devices = selectList2;
            SelectList selectList3 = new SelectList(db.Result, "Id", "Name");
            ViewBag.Result = selectList3;
            var work = from p in db.Workers
                       where p.Programmist == true
                       select p;
            SelectList selectList4 = new SelectList(work, "Id", "Name");
            ViewBag.Workers = selectList4;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Repair_add(Repair repair)
        {            
                db.Repair.Add(repair);
                await db.SaveChangesAsync();
                return RedirectToAction("Repair");                  
        }

        [HttpGet]
        public IActionResult Repair_edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("NotFoundComponent");
            }
            if (id == 0)
            {
                return RedirectToAction("NotFoundComponent");
            }
            SelectList selectList = new SelectList(db.Cabinets, "Id", "Name");
            ViewBag.Cabinets = selectList;
            SelectList selectList2 = new SelectList(db.Devices, "Id", "Name");
            ViewBag.Devices = selectList2;
            SelectList selectList3 = new SelectList(db.Result, "Id", "Name");
            ViewBag.Result = selectList3;
            var work = from p in db.Workers
                       where p.Programmist == true
                       select p;
            SelectList selectList4 = new SelectList(work, "Id", "Name");
            ViewBag.Workers = selectList4;
            var repair = (from p in db.Repair
                        where p.Id == id
                        select p).First();
            return View(repair);
        }

        [HttpPost]
        public async Task<IActionResult> Repair_edit(Repair repair)
        {
            db.Repair.Update(repair);
            await db.SaveChangesAsync();
            return RedirectToAction("Repair");
        }

        public async Task<IActionResult> Backup()
        {
            var backup = (from p in db.Backup_g
                          join cab_name in db.Cabinets on p.Cab_g equals cab_name.Id
                          join type_g in db.Type_g on p.Type_g equals type_g.Id
                          join vid_g in db.Vid_g on p.Vid_g equals vid_g.Id
                          join vid_copy in db.Vid_copy on p.Vid_copy equals vid_copy.Id                          
                          join name_g in db.Name_g on p.Name_g equals name_g.Id
                          join location_g in db.Name_g on p.Location_g equals location_g.Id
                          join result_g in db.Result_g on p.Result_g equals result_g.Id
                          join worker in db.Workers on p.Personal_g equals worker.Id
                          select new Backups
                          {
                              Backup_g = p,
                              Cabinet = cab_name,
                              Type_g = type_g,
                              Vid_g =  vid_g,
                              Vid_copy = vid_copy,
                              Name_g = name_g,
                              Name_gr= location_g,
                              Result_g = result_g,
                              Worker = worker
                          });
            ViewBag.backup = backup.Count();
            var computers = from p in db.Computers
                            select p;
            ViewBag.compcount = computers.Count();
            var printers = from p in db.Printers
                           select p;
            ViewBag.printercount = printers.Count();
            var components = from p in db.Components
                             select p;
            ViewBag.componentcount = components.Count();            
            return View(await backup.ToListAsync());
        }

        [HttpGet]
        public IActionResult Backup_add()
        {
            SelectList selectList = new SelectList(db.Cabinets, "Id", "Name");
            ViewBag.Cabinets = selectList;
            SelectList selectList2 = new SelectList(db.Type_g, "Id", "Name");
            ViewBag.Type_g = selectList2;
            SelectList selectList3 = new SelectList(db.Vid_g, "Id", "Name");
            ViewBag.Vid_g = selectList3;
            SelectList selectList4 = new SelectList(db.Vid_copy, "Id", "Name");
            ViewBag.Vid_copy = selectList4;
            SelectList selectList5 = new SelectList(db.Vid_copy, "Id", "Name");
            ViewBag.Vid_copy = selectList5;
            SelectList selectList6 = new SelectList(db.Name_g, "Id", "Name");
            ViewBag.Name_g = selectList6;            
            SelectList selectList7 = new SelectList(db.Result_g, "Id", "Name");
            ViewBag.Result_g = selectList7;
            var work = from p in db.Workers
                       where p.Programmist == true
                       select p;
            SelectList selectList8 = new SelectList(work, "Id", "Name");
            ViewBag.Workers = selectList8;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Backup_add(Backup_g backup)
        {
            db.Backup_g.Add(backup);
            await db.SaveChangesAsync();
            return RedirectToAction("Backup");
        }

        public IActionResult ReportComp()
        {            
            return View();
        }

        public IActionResult ComputerswithSoft()
        {
            return View();
        }

        public IActionResult NotFoundComponent()
        {
            return View();
        }

        public ActionResult ExportComp()
        {
            var comp = from p in db.Computers
                       select p;
            ViewBag.count = comp.Count();
            ViewBag.Computers = comp;
            var computer = comp.ToList();
            using (XLWorkbook workbook = new XLWorkbook(XLEventTracking.Disabled))
            {
                var worksheet = workbook.Worksheets.Add("Computers");

                worksheet.Cell("A1").Value = "Имя";
                worksheet.Cell("B1").Value = "Должность";
                worksheet.Cell("C1").Value = "Кабинет";
                worksheet.Cell("D1").Value = "Инв.номер компьютера";
                worksheet.Cell("E1").Value = "Инв.номер монитора";
                worksheet.Cell("F1").Value = "Руководитель подразделения";
                worksheet.Cell("G1").Value = "Дата поставки";
                worksheet.Row(1).Style.Font.Bold = true;

                //нумерация строк/столбцов начинается с индекса 1 (не 0)
                for (int i = 0; i < computer.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = computer[i].Name;
                    worksheet.Cell(i + 2, 2).Value = computer[i].Dolgnost;
                    worksheet.Cell(i + 2, 3).Value = computer[i].Cab;
                    worksheet.Cell(i + 2, 4).Value = computer[i].Sys_inv_c;
                    worksheet.Cell(i + 2, 5).Value = computer[i].Sys_inv_m;
                    worksheet.Cell(i + 2, 6).Value = computer[i].Rukov_podr;
                    worksheet.Cell(i + 2, 7).Value = computer[i].Data;
                    //worksheet.Cell(i + 2, 2).Value = string.Join(", ", computer[i].Cab.Select(x => x.Title));
                }
                var count = computer.Count + 1;
                var rngTable = worksheet.Range("A1:G" + count);
                rngTable.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                worksheet.Columns().AdjustToContents(); //ширина столбца по содержимому

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    stream.Flush();

                    return new FileContentResult(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        FileDownloadName = $"Comp_{DateTime.UtcNow.ToShortDateString()}.xlsx"
                    };
                }
            }
        }

        public IActionResult ReportPrint()
        {
            return View();
        }

        public ActionResult ExportPrinter()
        {
            //var print = from p in db.Printers
            //           select p;
            var print = (from p in db.Printers
                         join printer_name in db.Printer_name on p.Name_id equals printer_name.Id
                         join printer_type in db.Printer_type on p.Type_id equals printer_type.Id
                         join printer_tex in db.Printer_texnology on p.Tex_id equals printer_tex.Id
                         join printer_format in db.Printer_format on p.Cart_id equals printer_format.Id
                         select new Printerwithcart
                         {
                             Printer = p,
                             Printer_name = printer_name,
                             Printer_type = printer_type,
                             Printer_texnology = printer_tex,
                             Printer_format = printer_format
                         }).ToList();
            ViewBag.count = print.Count();
            ViewBag.Printers = print;
            var printer = print.ToList();
            int nomer = 1;
            using (XLWorkbook workbook = new XLWorkbook(XLEventTracking.Disabled))
            {
                var worksheet = workbook.Worksheets.Add("Printers");

                worksheet.Cell("A1").Value = "№ п/п";
                worksheet.Cell("B1").Value = "№ Кабинета";
                worksheet.Cell("C1").Value = "Инв.номер принтера";
                worksheet.Cell("D1").Value = "Наименование";
                worksheet.Cell("E1").Value = "Тип";
                worksheet.Cell("F1").Value = "Технология печати";
                worksheet.Cell("G1").Value = "Тип картриджа";
                //worksheet.Cell("G1").Value = "Дата поставки";
                worksheet.Row(1).Style.Font.Bold = true;

                //нумерация строк/столбцов начинается с индекса 1 (не 0)
                for (int i = 0; i < printer.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = nomer;
                    worksheet.Cell(i + 2, 2).Value = printer[i].Printer.Cab_p;
                    worksheet.Cell(i + 2, 3).Value = printer[i].Printer.Sys_inv_p;
                    worksheet.Cell(i + 2, 4).Value = printer[i].Printer_name.Name;
                    worksheet.Cell(i + 2, 5).Value = printer[i].Printer_type.Name;
                    worksheet.Cell(i + 2, 6).Value = printer[i].Printer_texnology.Name;
                    worksheet.Cell(i + 2, 7).Value = printer[i].Printer_format.Name;
                    //worksheet.Cell(i + 2, 7).Value = printer[i].Data;                    
                }
                var count = printer.Count + 1;
                var rngTable = worksheet.Range("A1:F" + count);
                rngTable.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                worksheet.Columns().AdjustToContents(); //ширина столбца по содержимому

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    stream.Flush();

                    return new FileContentResult(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        FileDownloadName = $"Printer_{DateTime.UtcNow.ToShortDateString()}.xlsx"
                    };
                }
            }
        }

        public IActionResult ReportSoft()
        {
            return View();
        }

        public ActionResult ExportSoft()
        {
            var prog = (from p in db.Programms
                        join c in db.Os on p.Os_id equals c.Id
                        join o in db.Offices on p.Office_id equals o.Id
                        join a in db.Antivirus on p.Antivir_id equals a.Id
                        join b in db.Browsers on p.Browser_id equals b.Id
                        select new OsWithProgramm
                        {
                            Programm = p,
                            Os = c,
                            Office = o,
                            Antivirus = a,
                            Browser = b
                        }).ToList();
            ViewBag.count = prog.Count();
            ViewBag.Programms = prog;
            var programm = prog.ToList();
            int nomer = 1;
            using (XLWorkbook workbook = new XLWorkbook(XLEventTracking.Disabled))
            {
                var worksheet = workbook.Worksheets.Add("Printers");

                worksheet.Cell("A1").Value = "№ п/п";
                worksheet.Cell("B1").Value = "ОС";
                worksheet.Cell("C1").Value = "Офис";
                worksheet.Cell("D1").Value = "Антивирус";
                worksheet.Cell("E1").Value = "Браузер";
                //worksheet.Cell("G1").Value = "Дата поставки";
                worksheet.Row(1).Style.Font.Bold = true;

                //нумерация строк/столбцов начинается с индекса 1 (не 0)
                for (int i = 0; i < programm.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = nomer;
                    worksheet.Cell(i + 2, 2).Value = programm[i].Os.Name;
                    worksheet.Cell(i + 2, 3).Value = programm[i].Office.Name;
                    worksheet.Cell(i + 2, 4).Value = programm[i].Antivirus.Name;
                    worksheet.Cell(i + 2, 5).Value = programm[i].Browser.Name;
                    //worksheet.Cell(i + 2, 2).Value = string.Join(", ", computer[i].Cab.Select(x => x.Title));
                    nomer++;
                }
                var count = programm.Count + 1;
                var rngTable = worksheet.Range("A1:E" + count);
                rngTable.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                worksheet.Columns().AdjustToContents(); //ширина столбца по содержимому

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    stream.Flush();

                    return new FileContentResult(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        FileDownloadName = $"Soft_{DateTime.UtcNow.ToShortDateString()}.xlsx"
                    };
                }
            }
        }

        public IActionResult ReportNetwork()
        {
            return View();
        }

        public ActionResult ExportNetwork()
        {
            var net = (from p in db.Networks
                       join str_pod in db.Otdels on p.Str_pod equals str_pod.Id
                       join fio in db.Workers on p.Fio equals fio.Id
                       join cabinet in db.Cabinets on p.Cabinet equals cabinet.Id                       
                       select new Nets
                       {
                           Network = p,
                           Otdel = str_pod,
                           Worker = fio,
                           Cabinet = cabinet                           
                       });
            ViewBag.count = net.Count();
            ViewBag.Setis = net;
            var network = net.ToList();
            using (XLWorkbook workbook = new XLWorkbook(XLEventTracking.Disabled))
            {
                var worksheet = workbook.Worksheets.Add("Networks");

                worksheet.Cell("A1").Value = "Подразделение";
                worksheet.Cell("B1").Value = "ФИО";
                worksheet.Cell("C1").Value = "Должность";
                worksheet.Cell("D1").Value = "Кабинет";
                worksheet.Cell("E1").Value = "Инв.номер";
                worksheet.Cell("F1").Value = "Описание";
                worksheet.Row(1).Style.Font.Bold = true;

                //нумерация строк/столбцов начинается с индекса 1 (не 0)
                for (int i = 0; i < network.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = network[i].Otdel.Name;
                    worksheet.Cell(i + 2, 2).Value = network[i].Worker.Name;
                    worksheet.Cell(i + 2, 3).Value = network[i].Network.Dolg;
                    worksheet.Cell(i + 2, 4).Value = network[i].Cabinet.Name;
                    worksheet.Cell(i + 2, 5).Value = network[i].Network.Activ_inv;
                    worksheet.Cell(i + 2, 6).Value = network[i].Network.Notice;
                    //worksheet.Cell(i + 2, 2).Value = string.Join(", ", computer[i].Cab.Select(x => x.Title));
                }
                var count = network.Count + 1;
                var rngTable = worksheet.Range("A1:F" + count);
                rngTable.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                worksheet.Columns().AdjustToContents(); //ширина столбца по содержимому

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    stream.Flush();

                    return new FileContentResult(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        FileDownloadName = $"Net_{DateTime.UtcNow.ToShortDateString()}.xlsx"
                    };
                }
            }
        }

        public IActionResult ReportServer()
        {
            return View();
        }

        public ActionResult ExportServer()
        {
            var net = (from p in db.Servers
                       join sm in db.Server_model on p.Model_id equals sm.Id
                       join sc in db.Server_cpu on p.Cpu_type_id equals sc.Id
                       join pc in db.Proc_ch on p.Cpu_ch_id equals pc.Id
                       join ht in db.Server_hdd_type on p.Hdd_type_id equals ht.Id
                       join hb in db.Hdd_ob on p.Hdd_ob_id equals hb.Id
                       join r in db.Ram_ob on p.Ram_id equals r.Id
                       join Name_server in db.Server_type on p.Name_server equals Name_server.Id
                       join Otdel in db.Otdels on p.Departament equals Otdel.Id
                       join Fio_admin in db.Workers on p.FIO_admin equals Fio_admin.Id
                       select new ServerWithDetail
                       {
                           Server = p,
                           Server_type = Name_server,
                           Otdel = Otdel,                           
                           Worker = Fio_admin,
                           Server_model = sm,
                           Server_cpu = sc,
                           Proc_ch = pc,
                           Server_hdd_type = ht,
                           Hdd_ob = hb,
                           Ram_ob = r
                       }).ToList();
            ViewBag.count = net.Count();
            ViewBag.ServerPs = net;
            var server = net.ToList();
            using (XLWorkbook workbook = new XLWorkbook(XLEventTracking.Disabled))
            {
                var worksheet = workbook.Worksheets.Add("Server");

                worksheet.Cell("A1").Value = "Подразделение";
                worksheet.Cell("B1").Value = "ФИО Админа";
                worksheet.Cell("C1").Value = "Телефон";
                worksheet.Cell("D1").Value = "Серийный номер";
                worksheet.Cell("E1").Value = "Инв.номер";
                worksheet.Cell("F1").Value = "Кол-во процессоров";
                worksheet.Cell("G1").Value = "Кол-во дисков";
                worksheet.Cell("H1").Value = "Модель";
                worksheet.Cell("I1").Value = "Процессор";
                worksheet.Cell("J1").Value = "Частота";
                worksheet.Cell("K1").Value = "Тип диска";
                worksheet.Cell("L1").Value = "Объем диска";
                worksheet.Cell("M1").Value = "Объем памяти";
                worksheet.Row(1).Style.Font.Bold = true;

                //нумерация строк/столбцов начинается с индекса 1 (не 0)
                for (int i = 0; i < server.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = server[i].Otdel.Name;
                    worksheet.Cell(i + 2, 2).Value = server[i].Worker.Name;
                    worksheet.Cell(i + 2, 3).Value = server[i].Server.Phone;
                    worksheet.Cell(i + 2, 4).Value = server[i].Server.Server_sn;
                    worksheet.Cell(i + 2, 5).Value = server[i].Server.Server_inv;
                    worksheet.Cell(i + 2, 6).Value = server[i].Server.Cpu_col;
                    worksheet.Cell(i + 2, 7).Value = server[i].Server.Hdd_col;
                    worksheet.Cell(i + 2, 8).Value = server[i].Server_model.Name;
                    worksheet.Cell(i + 2, 9).Value = server[i].Server_cpu.Name;
                    worksheet.Cell(i + 2, 10).Value = server[i].Proc_ch.Name;
                    worksheet.Cell(i + 2, 11).Value = server[i].Server_hdd_type.Name;
                    worksheet.Cell(i + 2, 12).Value = server[i].Hdd_ob.Name;
                    worksheet.Cell(i + 2, 13).Value = server[i].Ram_ob.Name;
                    //worksheet.Cell(i + 2, 2).Value = string.Join(", ", computer[i].Cab.Select(x => x.Title));
                }
                var count = server.Count + 1;
                var rngTable = worksheet.Range("A1:M" + count);
                rngTable.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                worksheet.Columns().AdjustToContents(); //ширина столбца по содержимому

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    stream.Flush();

                    return new FileContentResult(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        FileDownloadName = $"Server_{DateTime.UtcNow.ToShortDateString()}.xlsx"
                    };
                }
            }
        }

        public IActionResult ReportComponent()
        {
            return View();
        }

        public ActionResult ExportComponent()
        {
            var hard = (from p in db.Components
                        join cabinet_name in db.Cabinets on p.Cab equals cabinet_name.Id
                        select new Componentwithelement
                        {
                            Component = p,
                            Cabinet = cabinet_name
                        });
            ViewBag.count = hard.Count();
            ViewBag.Components = hard;
            var network = hard.ToList();
            using (XLWorkbook workbook = new XLWorkbook(XLEventTracking.Disabled))
            {
                var worksheet = workbook.Worksheets.Add("Components");

                worksheet.Cell("A1").Value = "Наименование";
                worksheet.Cell("B1").Value = "Кабинет";
                worksheet.Cell("C1").Value = "Кол-во";
                worksheet.Cell("D1").Value = "Расход";
                worksheet.Cell("E1").Value = "Остаток";
                worksheet.Row(1).Style.Font.Bold = true;

                //нумерация строк/столбцов начинается с индекса 1 (не 0)
                for (int i = 0; i < network.Count; i++)
                {
                    worksheet.Cell(i + 2, 1).Value = network[i].Component.Hard_name;
                    worksheet.Cell(i + 2, 2).Value = network[i].Cabinet.Name;
                    worksheet.Cell(i + 2, 3).Value = network[i].Component.Col;
                    worksheet.Cell(i + 2, 4).Value = network[i].Component.Expense;
                    worksheet.Cell(i + 2, 5).Value = network[i].Component.Residue;
                    //worksheet.Cell(i + 2, 2).Value = string.Join(", ", computer[i].Cab.Select(x => x.Title));
                }
                var count = network.Count + 1;
                var rngTable = worksheet.Range("A1:E" + count);
                rngTable.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                worksheet.Columns().AdjustToContents(); //ширина столбца по содержимому

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    stream.Flush();

                    return new FileContentResult(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        FileDownloadName = $"Component_{DateTime.UtcNow.ToShortDateString()}.xlsx"
                    };
                }
            }
        }

        public ActionResult TotalReport()
        {
            var org = from p in db.Organizations
                      select p;
            ViewBag.Organizations = org;
            var organization = org.ToList();
            var comp = from p in db.Computers
                       select p;
            var count = comp.Count();
            var comp2 = from p in db.Computers
                        where p.Data <= 2014
                        select p;
            var count2 = comp2.Count();
            var comp3 = from p in db.Computers
                        where p.Data == 2015
                        select p;
            var count3 = comp3.Count();
            var comp4 = from p in db.Computers
                        where p.Data == 2016
                        select p;
            var count4 = comp4.Count();
            var comp5 = from p in db.Computers
                        where p.Data == 2017
                        select p;
            var count5 = comp5.Count();
            var comp6 = from p in db.Computers
                        where p.Data == 2018
                        select p;
            var count6 = comp6.Count();
            var comp7 = from p in db.Computers
                        where p.Data == 2019
                        select p;
            var count7 = comp7.Count();
            ViewBag.Computers = comp;
            var computer = comp.ToList();
            var print = from p in db.Printers
                        select p;
            var pcount = print.Count();
            var server = from p in db.Servers
                         select p;
            ViewBag.ServerPs = server;
            var servercount = server.Count();
            var serverdata = server.ToList();
            using (XLWorkbook workbook = new XLWorkbook(XLEventTracking.Disabled))
            {
                var worksheet = workbook.Worksheets.Add("TotalReport");

                worksheet.Cell("A1").Value = "№ п/п";
                worksheet.Cell("B1").Value = "Наименование МО";
                worksheet.Cell("C1").Value = "Адрес";
                worksheet.Cell("D1").Value = "Персональные компьютеры";
                worksheet.Cell("D2").Value = "Всего";
                worksheet.Cell("E2").Value = "до 2014";
                worksheet.Cell("F2").Value = "2015";
                worksheet.Cell("G2").Value = "2016";
                worksheet.Cell("H2").Value = "2017";
                worksheet.Cell("I2").Value = "2018";
                worksheet.Cell("J2").Value = "2019";
                worksheet.Cell("K1").Value = "Принтеры";
                worksheet.Cell("L1").Value = "Серверное оборудование";
                worksheet.Cell("L2").Value = "Количество";
                worksheet.Cell("M2").Value = "Дата поставки";
                worksheet.Row(1).Style.Font.Bold = true;
                worksheet.Cell(3, 1).Value = 1;
                worksheet.Cell(3, 2).Value = organization[0].Name_org;
                worksheet.Cell(3, 3).Value = organization[0].Adres_org;
                worksheet.Cell(3, 4).Value = count;
                worksheet.Cell(3, 5).Value = count2;
                worksheet.Cell(3, 6).Value = count3;
                worksheet.Cell(3, 7).Value = count4;
                worksheet.Cell(3, 8).Value = count5;
                worksheet.Cell(3, 9).Value = count6;
                worksheet.Cell(3, 10).Value = count7;
                worksheet.Cell(3, 11).Value = pcount;
                worksheet.Cell(3, 12).Value = servercount;
                worksheet.Cell(3, 13).Value = serverdata[0].Data;
                var unityCelA = worksheet.Range("A1:A2");
                unityCelA.Merge(true);
                var unityCelB = worksheet.Range("B1:B2");
                unityCelB.Merge(true);
                var unityCelC = worksheet.Range("C1:C2");
                unityCelC.Merge(true);
                var unityCelJ = worksheet.Range("K1:K2");
                unityCelJ.Merge(true);
                var unityTable = worksheet.Range("D1:J1");
                unityTable.Merge(true);
                var unityCelK = worksheet.Range("L1:M1");
                unityCelK.Merge(true);
                unityTable.Style.Alignment.WrapText = true;
                var rngTable = worksheet.Range("A1:M3");
                rngTable.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                worksheet.Columns().AdjustToContents(); //ширина столбца по содержимому
                worksheet.Columns("11").Width = 10;

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    stream.Flush();

                    return new FileContentResult(stream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                    {
                        FileDownloadName = $"Total_{DateTime.UtcNow.ToShortDateString()}.xlsx"
                    };
                }
            }
        }

        public IActionResult Exit()
        {            
            HttpContext.Session.Remove(SessionName);
            return RedirectToAction("Index", "Home");            
        }

        public async Task<IActionResult> UserProfile()
        {
            var user = from p in db.Users
                       select p;
            ViewBag.user = username;
            return View(await user.ToListAsync());
        }

        [HttpGet]
        public IActionResult User_add()
        {
            ViewBag.user = username;
            ViewBag.userid = GenRandomString("QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm", 10);
            return View();
        }

        [HttpPost]
        public IActionResult User_add(User reg)
        {
            if (ModelState.IsValid)
            {
                User user = null;
                p = GetHashString(reg.Passwd);
                reg.Passwd = p;
                string userid;
                userid = GenRandomString("QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm", 10);
                using (db)
                {
                    user = db.Users.FirstOrDefault(u => u.LoginUser == reg.LoginUser);
                }
                if (user == null)
                {
                    using (db)
                    {
                        db.Users.Add(new User { UserId = userid, Fio = reg.Fio, Dolgnost = reg.Dolgnost, LoginUser = reg.LoginUser, Passwd = reg.Passwd, Data = DateTime.Now });
                        db.SaveChanges();
                        user = db.Users.Where(u => u.LoginUser == reg.LoginUser && u.Passwd == reg.Passwd).FirstOrDefault();
                    }                
                if (user != null)
                {                                     
                    return RedirectToAction("Index", "Home");
                }
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с таким логином уже существует!");
                }
            }
            return View(reg);
        }

        [HttpGet]
        public IActionResult User_edit()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
