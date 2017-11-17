using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUAN_LY_CUA_HANG_VLXD
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Form checkForm(Type ftype)
        {
            foreach (var f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form CfrmTK = checkForm(typeof(frmTaiKhoan));
            if (CfrmTK != null)
            {
                CfrmTK.Activate();
            }
            else
            {
                frmTaiKhoan frKH = new frmTaiKhoan();
                frKH.MdiParent = this;
                frKH.Show();
            }
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form CfrmKH = checkForm(typeof(frmKhachHang));
                if (CfrmKH != null)
                {
                    CfrmKH.Activate();
                }
                else
                {
                    frmKhachHang frKH = new frmKhachHang();
                    frKH.MdiParent = this;
                    frKH.Show();
                }
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form CfrmNCC = checkForm(typeof(frmNhaCungCap));
                if (CfrmNCC != null)
                {
                    CfrmNCC.Activate();
                }
                else
                {
                    frmNhaCungCap frNCC = new frmNhaCungCap();
                    frNCC.MdiParent = this;
                    frNCC.Show();
                }
        }

        private void btnSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form CfrmSP = checkForm(typeof(frmSanPham));
                if (CfrmSP != null)
                {
                    CfrmSP.Activate();
                }
                else
                {
                    frmSanPham frSP = new frmSanPham();
                    frSP.MdiParent = this;
                    frSP.Show();
                }
        }

        private void btnHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form CfrmHD = checkForm(typeof(frmHoaDon));
            if (CfrmHD != null)
            {
                CfrmHD.Activate();
            }
            else
            {
                frmHoaDon frHD = new frmHoaDon();
                frHD.MdiParent = this;
                frHD.Show();
            }
        }

        private void btnKiemKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form CfrmKK = checkForm(typeof(frmKiemKe));
            if (CfrmKK != null)
            {
                CfrmKK.Activate();
            }
            else
            {
                frmKiemKe frKK = new frmKiemKe();
                frKK.MdiParent = this;
                frKK.Show();
            }
        }

        private void btnThongKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form CfrmHD = checkForm(typeof(frmThongKe));
            if (CfrmHD != null)
            {
                CfrmHD.Activate();
            }
            else
            {
                frmThongKe frHD = new frmThongKe();
                frHD.MdiParent = this;
                frHD.Show();
            }
        }

        private void btnLapHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form CfrmHD = checkForm(typeof(frmLapHoaDon));
            if (CfrmHD != null)
            {
                CfrmHD.Activate();
            }
            else
            {
                frmLapHoaDon frHD = new frmLapHoaDon();
                frHD.MdiParent = this;
                frHD.Show();
            }
        }

        private void btnLapKiemKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form CfrmHD = checkForm(typeof(frmTaoKiemKe));
            if (CfrmHD != null)
            {
                CfrmHD.Activate();
            }
            else
            {
                frmTaoKiemKe frHD = new frmTaoKiemKe();
                frHD.MdiParent = this;
                frHD.Show();
            }
        }

        private void btnLapThongKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form CfrmHD = checkForm(typeof(frmTaoThongKe));
            if (CfrmHD != null)
            {
                CfrmHD.Activate();
            }
            else
            {
                frmTaoThongKe frHD = new frmTaoThongKe();
                frHD.MdiParent = this;
                frHD.Show();
            }
        }

        private void tbMenu_Click(object sender, EventArgs e)
        {
            //if (e.Item.Caption == "Khách Mua Hàng")
            //{
            //    Form CfrmKH = checkForm(typeof(frmKhachHang));
            //    if (CfrmKH != null)
            //    {
            //        CfrmKH.Activate();
            //    }
            //    else
            //    {
            //        frmKhachHang frKH = new frmKhachHang();
            //        frKH.MdiParent = this;
            //        frKH.Show();
            //    }
            //}

            //if (e.Item.Caption == "Nhân Viên")
            //{
            //    Form CfrmNV = checkForm(typeof(frmNhanVien));
            //    if (CfrmNV != null)
            //    {
            //        CfrmNV.Activate();
            //    }
            //    else
            //    {
            //        frmNhanVien frNV = new frmNhanVien();
            //        frNV.MdiParent = this;
            //        frNV.Show();
            //    }
            //}

            //if (e.Item.Caption == "Nhà Cung Cấp")
            //{
            //    Form CfrmNCC = checkForm(typeof(frmNhaCungCap));
            //    if (CfrmNCC != null)
            //    {
            //        CfrmNCC.Activate();
            //    }
            //    else
            //    {
            //        frmNhaCungCap frNCC = new frmNhaCungCap();
            //        frNCC.MdiParent = this;
            //        frNCC.Show();
            //    }
            //}

            //if (e.Item.Caption == "Sản Phẩm")
            //{
            //    Form CfrmSP = checkForm(typeof(frmSanPham));
            //    if (CfrmSP != null)
            //    {
            //        CfrmSP.Activate();
            //    }
            //    else
            //    {
            //        frmSanPham frSP = new frmSanPham();
            //        frSP.MdiParent = this;
            //        frSP.Show();
            //    }
            //}

            //if (e.Item.Caption == "Hóa Đơn")
            //{
            //    Form CfrmHD = checkForm(typeof(frmHoaDon));
            //    if (CfrmHD != null)
            //    {
            //        CfrmHD.Activate();
            //    }
            //    else
            //    {
            //        frmHoaDon frHD = new frmHoaDon();
            //        frHD.MdiParent = this;
            //        frHD.Show();
            //    }
            //}

            //if (e.Item.Caption == "Thống Kê")
            //{
            //    Form CfrmTK = checkForm(typeof(frmTaoThongKe));
            //    if (CfrmTK != null)
            //    {
            //        CfrmTK.Activate();
            //    }
            //    else
            //    {
            //        frmTaoThongKe frTK = new frmTaoThongKe();
            //        frTK.MdiParent = this;
            //        frTK.Show();
            //    }
            //}

            //if (e.Item.Caption == "Kiểm Kê")
            //{
            //    Form CfrmKK = checkForm(typeof(frmTaoKiemKe));
            //    if (CfrmKK != null)
            //    {
            //        CfrmKK.Activate();
            //    }
            //    else
            //    {
            //        frmTaoKiemKe frKK = new frmTaoKiemKe();
            //        frKK.MdiParent = this;
            //        frKK.Show();
            //    }
            //}
        }

        private void tbTaiKhoan_ItemChanged(object sender, DevExpress.XtraToolbox.ToolboxItemChangedEventArgs e)
        {

        }

        //    public void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //    {
        //        Form CfrmKH = checkForm(typeof(frmKhachHang));
        //        if (CfrmKH != null)
        //        {
        //            CfrmKH.Activate();
        //        }
        //        else
        //        {
        //            frmKhachHang frKH = new frmKhachHang();
        //            frKH.MdiParent = this;
        //            frKH.Show();
        //        }
        //    }

        

        //    private void btnNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //    {
        //        Form CfrmNCC = checkForm(typeof(frmNhaCungCap));
        //        if (CfrmNCC!=null)
        //        {
        //            CfrmNCC.Activate();
        //        }
        //        else
        //        {
        //            frmNhaCungCap frNCC = new frmNhaCungCap();
        //            frNCC.MdiParent = this;
        //            frNCC.Show();
        //        }
        //    }

        //    private void btnSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //    {
        //        Form CfrmSP = checkForm(typeof(frmSanPham));
        //        if (CfrmSP!=null)
        //        {
        //            CfrmSP.Activate();
        //        }
        //        else
        //        {
        //            frmSanPham frSP = new frmSanPham();
        //            frSP.MdiParent = this;
        //            frSP.Show();
        //        }
        //    }

        //    private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //    {
        //        Form CfrmNV = checkForm(typeof(frmNhanVien));
        //        if (CfrmNV!=null)
        //        {
        //            CfrmNV.Activate();
        //        }
        //        else
        //        {
        //            frmNhanVien frNV = new frmNhanVien();
        //            frNV.MdiParent = this;
        //            frNV.Show();
        //        }
        //    }

        //    private void btnLapHoaDon_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //    {
        //        Form CfrmHD = checkForm(typeof(frmLapHoaDon));
        //        if (CfrmHD != null)
        //        {
        //            CfrmHD.Activate();
        //        }
        //        else
        //        {
        //            frmLapHoaDon frHD = new frmLapHoaDon();
        //            frHD.MdiParent = this;
        //            frHD.Show();
        //        }
        //    }

        //    private void btnTaoKiemKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //    {
        //        Form CfrmKK = checkForm(typeof(frmTaoKiemKe));
        //        if (CfrmKK!=null)
        //        {
        //            CfrmKK.Activate();
        //        }
        //        else
        //        {
        //            frmTaoKiemKe frKK = new frmTaoKiemKe();
        //            frKK.MdiParent = this;
        //            frKK.Show();
        //        }
        //    }

        //    private void btnTaoThongKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //    {
        //        Form CfrmTK = checkForm(typeof(frmTaoThongKe));
        //        if (CfrmTK != null)
        //        {
        //            CfrmTK.Activate();
        //        }
        //        else
        //        {
        //            frmTaoThongKe frTK = new frmTaoThongKe();
        //            frTK.MdiParent = this;
        //            frTK.Show();
        //        }
        //    }

        //    private void toolboxControl1_ItemClick(object sender, DevExpress.XtraToolbox.ToolboxItemClickEventArgs e)
        //    {
        //        if (e.Item.Caption== "Khách Mua Hàng")
        //        {
        //            Form CfrmKH = checkForm(typeof(frmKhachHang));
        //            if (CfrmKH != null)
        //            {
        //                CfrmKH.Activate();
        //            }
        //            else
        //            {
        //                frmKhachHang frKH = new frmKhachHang();
        //                frKH.MdiParent = this;
        //                frKH.Show();
        //            }
        //        }

        //        if (e.Item.Caption == "Nhân Viên")
        //        {
        //            Form CfrmNV = checkForm(typeof(frmNhanVien));
        //            if (CfrmNV != null)
        //            {
        //                CfrmNV.Activate();
        //            }
        //            else
        //            {
        //                frmNhanVien frNV = new frmNhanVien();
        //                frNV.MdiParent = this;
        //                frNV.Show();
        //            }
        //        }

        //        if (e.Item.Caption == "Nhà Cung Cấp")
        //        {
        //            Form CfrmNCC = checkForm(typeof(frmNhaCungCap));
        //            if (CfrmNCC != null)
        //            {
        //                CfrmNCC.Activate();
        //            }
        //            else
        //            {
        //                frmNhaCungCap frNCC = new frmNhaCungCap();
        //                frNCC.MdiParent = this;
        //                frNCC.Show();
        //            }
        //        }

        //        if (e.Item.Caption == "Sản Phẩm")
        //        {
        //            Form CfrmSP = checkForm(typeof(frmSanPham));
        //            if (CfrmSP != null)
        //            {
        //                CfrmSP.Activate();
        //            }
        //            else
        //            {
        //                frmSanPham frSP = new frmSanPham();
        //                frSP.MdiParent = this;
        //                frSP.Show();
        //            }
        //        }

        //        if (e.Item.Caption == "Hóa Đơn")
        //        {
        //            Form CfrmHD = checkForm(typeof(frmHoaDon));
        //            if (CfrmHD != null)
        //            {
        //                CfrmHD.Activate();
        //            }
        //            else
        //            {
        //                frmHoaDon frHD = new frmHoaDon();
        //                frHD.MdiParent = this;
        //                frHD.Show();
        //            }
        //        }

        //        if (e.Item.Caption == "Thống Kê")
        //        {
        //            Form CfrmTK = checkForm(typeof(frmTaoThongKe));
        //            if (CfrmTK != null)
        //            {
        //                CfrmTK.Activate();
        //            }
        //            else
        //            {
        //                frmTaoThongKe frTK = new frmTaoThongKe();
        //                frTK.MdiParent = this;
        //                frTK.Show();
        //            }
        //        }

        //        if (e.Item.Caption == "Kiểm Kê")
        //        {
        //            Form CfrmKK = checkForm(typeof(frmTaoKiemKe));
        //            if (CfrmKK != null)
        //            {
        //                CfrmKK.Activate();
        //            }
        //            else
        //            {
        //                frmTaoKiemKe frKK = new frmTaoKiemKe();
        //                frKK.MdiParent = this;
        //                frKK.Show();
        //            }
        //        }

        //    }

        //    private void btnLapHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //    {
        //        Form CfrmLapHoaDon = checkForm(typeof(frmLapHoaDon));
        //        if (CfrmLapHoaDon != null)
        //        {
        //            CfrmLapHoaDon.Activate();
        //        }
        //        else
        //        {
        //            frmLapHoaDon frNV = new frmLapHoaDon();
        //            frNV.MdiParent = this;
        //            frNV.Show();
        //        }
        //    }

        //    private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //    {

        //    }

        //    private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //    {

        //    }


        //}
    }
}
