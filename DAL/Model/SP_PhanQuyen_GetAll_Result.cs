//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Model
{
    using System;
    
    public partial class SP_PhanQuyen_GetAll_Result
    {
        public int IDQuyen { get; set; }
        public int IDTaiKhoan { get; set; }
        public string GhiChu_QuyenJoin { get; set; }
        public string TenQuyen_QuyenJoin { get; set; }
        public string HoTen_TaiKhoanJoin { get; set; }
        public Nullable<int> IDChucVu_TaiKhoanJoin { get; set; }
        public Nullable<bool> IsDelete_TaiKhoanJoin { get; set; }
        public string MatKhau_TaiKhoanJoin { get; set; }
        public Nullable<System.DateTime> NgaySinh_TaiKhoanJoin { get; set; }
        public string SDT_TaiKhoanJoin { get; set; }
        public string TenDangNhap_TaiKhoanJoin { get; set; }
    }
}
