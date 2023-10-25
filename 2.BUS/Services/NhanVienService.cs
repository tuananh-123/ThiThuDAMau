using _1.DAL.IRepositories;
using _1.DAL.Models;
using _2.BUS.DTOs;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public sealed class NhanVienService : INhanVienSerivce
    {
        private readonly IManagerRepository<Nhanvien> _managerRepository;

        public NhanVienService(IManagerRepository<Nhanvien> managerRepository)
        {
            _managerRepository=managerRepository;
        }

        public List<NhanVienDto> GetAll()
        {
            var NhanVienL = _managerRepository.baseRepository.GetAll();
            if (NhanVienL != null)
            {
                return CatToDto(NhanVienL.ToList());
            }
            return new List<NhanVienDto>();
        }

        public List<NhanVienDto> GetByValue(string value)
        {
            var NhanVienL = _managerRepository.nhanvienRepository.GetByValue(value);
            if (NhanVienL != null)
                return CatToDto(NhanVienL.ToList());

            return new List<NhanVienDto>();
        }

        public List<NhanVienDto> CatToDto(List<Nhanvien> NhanvienL)
        {
            var NhanVienDto = NhanvienL.Select((item, index) => new NhanVienDto
            {
                STT = index + 1,
                Ten = item.Ten,
                DiaChi = item.Diachi,
                SoDienThoai = item.Sodienthoai!,
                NgayTuyenDung = (DateTime)item.Ngaytuyendung!
            }).ToList();
            return NhanVienDto;
        }

    }
}
