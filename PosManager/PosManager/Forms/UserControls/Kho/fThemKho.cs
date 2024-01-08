﻿using ComponentFactory.Krypton.Toolkit;
using DocumentFormat.OpenXml.Office2010.Excel;
using PosManager.APIServices.CaiDat;
using PosManager.APIServices.Kho;
using PosManager.Forms;
using PosManager.Helper;
using PosManager.Model;
using PosManager.Model.Kho;
using Serilog;

namespace Krypton_toolKitDemo
{
    public partial class fThemKho : KryptonForm
    {
        private StocksController _stocksController;
        private StockModel _stock { get; set; }
        public fThemKho(StockModel? stock)
        {
            InitializeComponent();
            _stock = stock;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_stock != null)
            {
                txtDiaChi.Text = _stock.MaKho;
                txtTen.Text = _stock.TenKho;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiaChi.Text) || string.IsNullOrEmpty(txtTen.Text))
            {
                MessageCommon.ShowMessageBox("Vui lòng nhập đủ thông tin!");
                return;
            }
            fLoading loading = new fLoading();
            loading.StartLoading();
            try
            {
                _stocksController = new StocksController();
                if (_stock != null)
                {
                    _stock.TenKho = txtDiaChi.Text;
                    _stock.MaKho = txtTen.Text;
                    var result = await _stocksController.Edit(GlobalModel.AccsessToken, _stock);
                    if (result != null)
                    {
                        loading.Close();
                        MessageCommon.ShowMessageBox(result.Message);
                    }
                    else
                    {
                        loading.Close();
                        MessageCommon.ShowMessageBox("Vui Lòng Thử Lại Sau!");
                    }
                }
                else
                {
                    StockModel stock = new StockModel();
                    stock.TenKho = txtTen.Text;
                    stock.MaKho = txtDiaChi.Text;
                    var result = await _stocksController.Add(GlobalModel.AccsessToken, stock);
                    if (result != null)
                    {
                        loading.Close();
                        MessageCommon.ShowMessageBox(result.Message);
                    }
                    else
                    {
                        loading.Close();
                        MessageCommon.ShowMessageBox("Vui Lòng Thử Lại Sau!");
                    }
                }
            }
            catch (Exception ex)
            {
                loading.Close();
                Log.Error(ex, ex.Message);
                MessageCommon.ShowMessageBox(ex.Message, 3);

            }
          
        }
    }
}
