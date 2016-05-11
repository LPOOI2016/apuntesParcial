namespace Vistas
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tltMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmStock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProduccion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBottom.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackgroundImage = global::Vistas.Properties.Resources.pie;
            this.pnlBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBottom.Controls.Add(this.lblClock);
            this.pnlBottom.Controls.Add(this.lblDate);
            this.pnlBottom.Controls.Add(this.lblUserLogin);
            this.pnlBottom.Controls.Add(this.btnMin);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 434);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 40);
            this.pnlBottom.TabIndex = 1;
            // 
            // lblClock
            // 
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.SystemColors.Window;
            this.lblClock.Location = new System.Drawing.Point(3, 10);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(98, 20);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "22:02:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDate.Location = new System.Drawing.Point(608, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(115, 25);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "28/10/2014";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUserLogin.Location = new System.Drawing.Point(223, 6);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(265, 28);
            this.lblUserLogin.TabIndex = 2;
            this.lblUserLogin.Text = "Bienvenido:";
            this.lblUserLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Maroon;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(729, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(36, 36);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "--";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(764, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.FrmMain_Load);
            // 
            // msMenu
            // 
            this.msMenu.AutoSize = false;
            this.msMenu.BackColor = System.Drawing.Color.Transparent;
            this.msMenu.BackgroundImage = global::Vistas.Properties.Resources.cabecera;
            this.msMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStock,
            this.tsmCompras,
            this.tsmProduccion,
            this.tsmVentas,
            this.tsmUsuarios,
            this.tsmLogOut});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(800, 90);
            this.msMenu.TabIndex = 3;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmStock
            // 
            this.tsmStock.AutoSize = false;
            this.tsmStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsmStock.ForeColor = System.Drawing.Color.White;
            this.tsmStock.Image = global::Vistas.Properties.Resources.stock1;
            this.tsmStock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmStock.Name = "tsmStock";
            this.tsmStock.Size = new System.Drawing.Size(100, 90);
            this.tsmStock.Text = "Stock y Articulos";
            this.tsmStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmStock.Visible = false;
            this.tsmStock.Click += new System.EventHandler(this.tsmStock_Click);
            this.tsmStock.MouseEnter += new System.EventHandler(this.tsmStock_MouseEnter);
            this.tsmStock.MouseLeave += new System.EventHandler(this.tsmStock_MouseLeave);
            // 
            // tsmCompras
            // 
            this.tsmCompras.AutoSize = false;
            this.tsmCompras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsmCompras.ForeColor = System.Drawing.Color.White;
            this.tsmCompras.Image = global::Vistas.Properties.Resources.buy1;
            this.tsmCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmCompras.Name = "tsmCompras";
            this.tsmCompras.Size = new System.Drawing.Size(90, 90);
            this.tsmCompras.Text = "Compras";
            this.tsmCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmCompras.Visible = false;
            this.tsmCompras.Click += new System.EventHandler(this.tsmCompras_Click);
            this.tsmCompras.MouseEnter += new System.EventHandler(this.tsmCompras_MouseEnter);
            this.tsmCompras.MouseLeave += new System.EventHandler(this.tsmCompras_MouseLeave);
            // 
            // tsmProduccion
            // 
            this.tsmProduccion.AutoSize = false;
            this.tsmProduccion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsmProduccion.ForeColor = System.Drawing.Color.White;
            this.tsmProduccion.Image = global::Vistas.Properties.Resources.product1;
            this.tsmProduccion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmProduccion.Name = "tsmProduccion";
            this.tsmProduccion.Size = new System.Drawing.Size(90, 90);
            this.tsmProduccion.Text = "Produccion";
            this.tsmProduccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmProduccion.Visible = false;
            this.tsmProduccion.MouseEnter += new System.EventHandler(this.tsmProduccion_MouseEnter);
            this.tsmProduccion.MouseLeave += new System.EventHandler(this.tsmProduccion_MouseLeave);
            // 
            // tsmVentas
            // 
            this.tsmVentas.AutoSize = false;
            this.tsmVentas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsmVentas.ForeColor = System.Drawing.Color.White;
            this.tsmVentas.Image = global::Vistas.Properties.Resources.sell1;
            this.tsmVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmVentas.Name = "tsmVentas";
            this.tsmVentas.Size = new System.Drawing.Size(90, 90);
            this.tsmVentas.Text = "Ventas";
            this.tsmVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmVentas.Visible = false;
            this.tsmVentas.MouseEnter += new System.EventHandler(this.tsmVentas_MouseEnter);
            this.tsmVentas.MouseLeave += new System.EventHandler(this.tsmVentas_MouseLeave);
            // 
            // tsmUsuarios
            // 
            this.tsmUsuarios.AutoSize = false;
            this.tsmUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsmUsuarios.ForeColor = System.Drawing.Color.White;
            this.tsmUsuarios.Image = global::Vistas.Properties.Resources.user1;
            this.tsmUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmUsuarios.Name = "tsmUsuarios";
            this.tsmUsuarios.Size = new System.Drawing.Size(90, 90);
            this.tsmUsuarios.Text = "Usuarios";
            this.tsmUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmUsuarios.Visible = false;
            this.tsmUsuarios.Click += new System.EventHandler(this.tsmUsuarios_Click);
            this.tsmUsuarios.MouseEnter += new System.EventHandler(this.tsmUsuarios_MouseEnter);
            this.tsmUsuarios.MouseLeave += new System.EventHandler(this.tsmUsuarios_MouseLeave);
            // 
            // tsmLogOut
            // 
            this.tsmLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmLogOut.Image = global::Vistas.Properties.Resources.logout1;
            this.tsmLogOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmLogOut.Name = "tsmLogOut";
            this.tsmLogOut.Size = new System.Drawing.Size(57, 86);
            this.tsmLogOut.Text = " ";
            this.tsmLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmLogOut.Click += new System.EventHandler(this.tsmLogOut_Click);
            this.tsmLogOut.MouseEnter += new System.EventHandler(this.tsmLogOut_MouseEnter);
            this.tsmLogOut.MouseLeave += new System.EventHandler(this.tsmLogOut_MouseLeave);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Vistas.Properties.Resources.cupcake;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.msMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlBottom.ResumeLayout(false);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip tltMensaje;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmStock;
        private System.Windows.Forms.ToolStripMenuItem tsmCompras;
        private System.Windows.Forms.ToolStripMenuItem tsmProduccion;
        private System.Windows.Forms.ToolStripMenuItem tsmVentas;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmLogOut;

    }
}