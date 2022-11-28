namespace GUI.View.UserControls
{
    partial class FrmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            this.LiveChart_ThongKe = new LiveCharts.WinForms.CartesianChart();
            this.dtg_thongke = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandTimeout = 30;
            this.sqlCommand2.Connection = null;
            this.sqlCommand2.Notification = null;
            this.sqlCommand2.Transaction = null;
            // 
            // LiveChart_ThongKe
            // 
            this.LiveChart_ThongKe.Location = new System.Drawing.Point(75, 43);
            this.LiveChart_ThongKe.Name = "LiveChart_ThongKe";
            this.LiveChart_ThongKe.Size = new System.Drawing.Size(1004, 337);
            this.LiveChart_ThongKe.TabIndex = 0;
            this.LiveChart_ThongKe.Text = "cartesianChart1";
            // 
            // dtg_thongke
            // 
            this.dtg_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_thongke.Location = new System.Drawing.Point(61, 524);
            this.dtg_thongke.Name = "dtg_thongke";
            this.dtg_thongke.RowHeadersWidth = 51;
            this.dtg_thongke.RowTemplate.Height = 29;
            this.dtg_thongke.Size = new System.Drawing.Size(548, 299);
            this.dtg_thongke.TabIndex = 1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1141, 851);
            this.Controls.Add(this.dtg_thongke);
            this.Controls.Add(this.LiveChart_ThongKe);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private LiveCharts.WinForms.CartesianChart LiveChart_ThongKe;
        private DataGridView dtg_thongke;
        private BindingSource bindingSource1;
    }
}