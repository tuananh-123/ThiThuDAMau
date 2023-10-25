using _1.DAL.Models;
using _2.BUS.DTOs;
using _2.BUS.IServices;
using _3.PRL.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PRL.Presenter
{
    public class MainPresenter
    {
        private IMainView view;
        private INhanVienSerivce _nhanVienSerivce;
        private BindingSource NhanVienSource;
        private IEnumerable<NhanVienDto> NhanVienList;

        public MainPresenter(IMainView view, INhanVienSerivce nhanVienSerivce)
        {
            NhanVienSource = new BindingSource();
            NhanVienList = new List<NhanVienDto>();
            this.view = view;
            this.view.SetBindingSource(NhanVienSource);
            this.view.ShowData += View_ShowData;
            this.view.SearchData += View_SearchData;


            this._nhanVienSerivce = nhanVienSerivce;
           
            this.view.Show();
        }

        private void View_SearchData(object? sender, EventArgs e)
        {
            bool checkNullString = string.IsNullOrEmpty(this.view.SearchValue);
            if (!checkNullString)
            {
                NhanVienList = _nhanVienSerivce.GetByValue(this.view.SearchValue);
            }
            else
            {
                NhanVienList = _nhanVienSerivce.GetAll();
            }
            NhanVienSource.DataSource = NhanVienList;

        }

        private void View_ShowData(object? sender, EventArgs e)
        {
            LoadNhanVienSource();
        }

        private void LoadNhanVienSource()
        {
            NhanVienList = _nhanVienSerivce.GetAll();
            NhanVienSource.DataSource = NhanVienList;
        }
    }
}
