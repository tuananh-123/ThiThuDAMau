using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.Services;
using _3.PRL.Presenter;
using _3.PRL.views;

namespace _3.PRL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            SOF205FINALNONEContext dbcontext = new SOF205FINALNONEContext();
            IManagerRepository<Nhanvien> managerRepository = new ManagerRepository<Nhanvien>(dbcontext);
            INhanVienSerivce nhanVienSerivce = new NhanVienService(managerRepository);
            IMainView view = new MainView();
            new MainPresenter(view, nhanVienSerivce);
            Application.Run((Form)view);
        }
    }
}