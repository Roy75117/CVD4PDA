
using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace CVD
{
	/// <summary>
	/// Form1 的摘要描述。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ComboBox sex;
		private System.Windows.Forms.NumericUpDown age;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown sbp;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown dbp;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown pr;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown hdl;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown total;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.CheckBox treat;
		private System.Windows.Forms.CheckBox murmur;
		private System.Windows.Forms.CheckBox heart_f;
		private System.Windows.Forms.CheckBox db;
		private System.Windows.Forms.CheckBox smoke;
		private System.Windows.Forms.CheckBox lvh;
		private System.Windows.Forms.CheckBox history;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ProgressBar pb;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox mediumicon;
		private System.Windows.Forms.PictureBox veryhighicon;
		private System.Windows.Forms.PictureBox highicon;
		private System.Windows.Forms.PictureBox healthicon;
		private System.Windows.Forms.NumericUpDown height;
		private System.Windows.Forms.Label u;
		private System.Windows.Forms.NumericUpDown waist;
		private System.Windows.Forms.NumericUpDown weight;
		private System.Windows.Forms.PictureBox lowicon;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.MainMenu mainMenu1;
		int hage,per;
		double cvd,stroke;

		public Form1()
		{
			//
			// Windows Form 設計工具支援的必要項
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 呼叫之後加入任何建構函式程式碼
			//
		}
		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			base.Dispose( disposing );
		}
		#region Windows Form 設計工具產生的程式碼
		/// <summary>
		/// 此為設計工具支援所必須的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.total = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.hdl = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.pr = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.dbp = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.sbp = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.height = new System.Windows.Forms.NumericUpDown();
			this.u = new System.Windows.Forms.Label();
			this.waist = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.weight = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.age = new System.Windows.Forms.NumericUpDown();
			this.sex = new System.Windows.Forms.ComboBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.history = new System.Windows.Forms.CheckBox();
			this.lvh = new System.Windows.Forms.CheckBox();
			this.smoke = new System.Windows.Forms.CheckBox();
			this.db = new System.Windows.Forms.CheckBox();
			this.heart_f = new System.Windows.Forms.CheckBox();
			this.murmur = new System.Windows.Forms.CheckBox();
			this.treat = new System.Windows.Forms.CheckBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.lowicon = new System.Windows.Forms.PictureBox();
			this.healthicon = new System.Windows.Forms.PictureBox();
			this.highicon = new System.Windows.Forms.PictureBox();
			this.veryhighicon = new System.Windows.Forms.PictureBox();
			this.mediumicon = new System.Windows.Forms.PictureBox();
			this.label18 = new System.Windows.Forms.Label();
			this.pb = new System.Windows.Forms.ProgressBar();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(250, 264);
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.label1_ParentChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.GreenYellow;
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.total);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.hdl);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.pr);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.dbp);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.sbp);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.height);
			this.tabPage1.Controls.Add(this.u);
			this.tabPage1.Controls.Add(this.waist);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.weight);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.age);
			this.tabPage1.Controls.Add(this.sex);
			this.tabPage1.Location = new System.Drawing.Point(4, 4);
			this.tabPage1.Size = new System.Drawing.Size(242, 239);
			this.tabPage1.Text = "Basic Data";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.label9.Location = new System.Drawing.Point(8, 8);
			this.label9.Size = new System.Drawing.Size(48, 16);
			this.label9.Text = "Gender";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(184, 192);
			this.pictureBox1.Size = new System.Drawing.Size(56, 48);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.label8.Location = new System.Drawing.Point(120, 200);
			this.label8.Size = new System.Drawing.Size(72, 16);
			this.label8.Text = "Total-chol";
			// 
			// total
			// 
			this.total.Location = new System.Drawing.Point(120, 216);
			this.total.Maximum = new System.Decimal(new int[] {
																  500,
																  0,
																  0,
																  0});
			this.total.Size = new System.Drawing.Size(56, 22);
			this.total.Value = new System.Decimal(new int[] {
																150,
																0,
																0,
																0});
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.label7.Location = new System.Drawing.Point(112, 152);
			this.label7.Size = new System.Drawing.Size(72, 16);
			this.label7.Text = "HDL-chol";
			// 
			// hdl
			// 
			this.hdl.Location = new System.Drawing.Point(120, 168);
			this.hdl.Maximum = new System.Decimal(new int[] {
																200,
																0,
																0,
																0});
			this.hdl.Size = new System.Drawing.Size(56, 22);
			this.hdl.Value = new System.Decimal(new int[] {
															  45,
															  0,
															  0,
															  0});
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.label6.Location = new System.Drawing.Point(104, 104);
			this.label6.Size = new System.Drawing.Size(96, 16);
			this.label6.Text = "PR inter.(mSec)";
			// 
			// pr
			// 
			this.pr.Location = new System.Drawing.Point(120, 120);
			this.pr.Maximum = new System.Decimal(new int[] {
															   300,
															   0,
															   0,
															   0});
			this.pr.Size = new System.Drawing.Size(56, 22);
			this.pr.Value = new System.Decimal(new int[] {
															 160,
															 0,
															 0,
															 0});
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.label5.Location = new System.Drawing.Point(112, 56);
			this.label5.Size = new System.Drawing.Size(80, 16);
			this.label5.Text = "DBP(mmHg)";
			// 
			// dbp
			// 
			this.dbp.Location = new System.Drawing.Point(120, 72);
			this.dbp.Maximum = new System.Decimal(new int[] {
																180,
																0,
																0,
																0});
			this.dbp.Minimum = new System.Decimal(new int[] {
																30,
																0,
																0,
																0});
			this.dbp.Size = new System.Drawing.Size(56, 22);
			this.dbp.Value = new System.Decimal(new int[] {
															  70,
															  0,
															  0,
															  0});
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.label4.Location = new System.Drawing.Point(112, 8);
			this.label4.Size = new System.Drawing.Size(80, 16);
			this.label4.Text = "SBP(mmHg)";
			// 
			// sbp
			// 
			this.sbp.Location = new System.Drawing.Point(120, 24);
			this.sbp.Maximum = new System.Decimal(new int[] {
																250,
																0,
																0,
																0});
			this.sbp.Minimum = new System.Decimal(new int[] {
																50,
																0,
																0,
																0});
			this.sbp.Size = new System.Drawing.Size(56, 22);
			this.sbp.Value = new System.Decimal(new int[] {
															  110,
															  0,
															  0,
															  0});
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.label3.Location = new System.Drawing.Point(8, 104);
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.Text = "Height(cm)";
			// 
			// height
			// 
			this.height.Location = new System.Drawing.Point(16, 120);
			this.height.Maximum = new System.Decimal(new int[] {
																   300,
																   0,
																   0,
																   0});
			this.height.Minimum = new System.Decimal(new int[] {
																   100,
																   0,
																   0,
																   0});
			this.height.Size = new System.Drawing.Size(56, 22);
			this.height.Value = new System.Decimal(new int[] {
																 175,
																 0,
																 0,
																 0});
			// 
			// u
			// 
			this.u.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.u.Location = new System.Drawing.Point(8, 200);
			this.u.Size = new System.Drawing.Size(112, 16);
			this.u.Text = "Waist Circum.(cm)";
			// 
			// waist
			// 
			this.waist.Location = new System.Drawing.Point(16, 216);
			this.waist.Maximum = new System.Decimal(new int[] {
																  200,
																  0,
																  0,
																  0});
			this.waist.Minimum = new System.Decimal(new int[] {
																  10,
																  0,
																  0,
																  0});
			this.waist.Size = new System.Drawing.Size(56, 22);
			this.waist.Value = new System.Decimal(new int[] {
																70,
																0,
																0,
																0});
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.label2.Location = new System.Drawing.Point(8, 152);
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.Text = "Weight(kg)";
			// 
			// weight
			// 
			this.weight.Location = new System.Drawing.Point(16, 168);
			this.weight.Maximum = new System.Decimal(new int[] {
																   200,
																   0,
																   0,
																   0});
			this.weight.Minimum = new System.Decimal(new int[] {
																   30,
																   0,
																   0,
																   0});
			this.weight.Size = new System.Drawing.Size(56, 22);
			this.weight.Value = new System.Decimal(new int[] {
																 75,
																 0,
																 0,
																 0});
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.label1.Location = new System.Drawing.Point(8, 56);
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.Text = "Age";
			this.label1.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
			// 
			// age
			// 
			this.age.Location = new System.Drawing.Point(16, 72);
			this.age.Minimum = new System.Decimal(new int[] {
																18,
																0,
																0,
																0});
			this.age.Size = new System.Drawing.Size(56, 22);
			this.age.Value = new System.Decimal(new int[] {
															  55,
															  0,
															  0,
															  0});
			// 
			// sex
			// 
			this.sex.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.sex.Items.Add("Male");
			this.sex.Items.Add("Female");
			this.sex.Location = new System.Drawing.Point(16, 24);
			this.sex.Size = new System.Drawing.Size(64, 24);
			this.sex.Text="Gender";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.LightBlue;
			this.tabPage2.Controls.Add(this.pictureBox2);
			this.tabPage2.Controls.Add(this.history);
			this.tabPage2.Controls.Add(this.lvh);
			this.tabPage2.Controls.Add(this.smoke);
			this.tabPage2.Controls.Add(this.db);
			this.tabPage2.Controls.Add(this.heart_f);
			this.tabPage2.Controls.Add(this.murmur);
			this.tabPage2.Controls.Add(this.treat);
			this.tabPage2.Location = new System.Drawing.Point(4, 4);
			this.tabPage2.Size = new System.Drawing.Size(242, 239);
			this.tabPage2.Text = "Medical History";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(8, 192);
			this.pictureBox2.Size = new System.Drawing.Size(224, 40);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			// 
			// history
			// 
			this.history.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.history.Location = new System.Drawing.Point(16, 160);
			this.history.Size = new System.Drawing.Size(192, 20);
			this.history.Text = "History of Diabetes(or Family)";
			// 
			// lvh
			// 
			this.lvh.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.lvh.Location = new System.Drawing.Point(16, 136);
			this.lvh.Size = new System.Drawing.Size(192, 20);
			this.lvh.Text = "Left Ventricular Hypertrophy";
			// 
			// smoke
			// 
			this.smoke.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.smoke.Location = new System.Drawing.Point(16, 112);
			this.smoke.Size = new System.Drawing.Size(192, 20);
			this.smoke.Text = "Smoke";
			// 
			// db
			// 
			this.db.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.db.Location = new System.Drawing.Point(16, 88);
			this.db.Size = new System.Drawing.Size(192, 20);
			this.db.Text = "Diabetes";
			// 
			// heart_f
			// 
			this.heart_f.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.heart_f.Location = new System.Drawing.Point(16, 64);
			this.heart_f.Size = new System.Drawing.Size(192, 20);
			this.heart_f.Text = "Prevalent Heart Failure";
			// 
			// murmur
			// 
			this.murmur.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.murmur.Location = new System.Drawing.Point(16, 40);
			this.murmur.Size = new System.Drawing.Size(192, 20);
			this.murmur.Text = "Significant Murmur";
			// 
			// treat
			// 
			this.treat.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.treat.Location = new System.Drawing.Point(16, 16);
			this.treat.Size = new System.Drawing.Size(192, 20);
			this.treat.Text = "Treat for Hypertension";
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.LightPink;
			this.tabPage3.Controls.Add(this.label21);
			this.tabPage3.Controls.Add(this.label20);
			this.tabPage3.Controls.Add(this.label19);
			this.tabPage3.Controls.Add(this.lowicon);
			this.tabPage3.Controls.Add(this.healthicon);
			this.tabPage3.Controls.Add(this.highicon);
			this.tabPage3.Controls.Add(this.veryhighicon);
			this.tabPage3.Controls.Add(this.mediumicon);
			this.tabPage3.Controls.Add(this.label18);
			this.tabPage3.Controls.Add(this.pb);
			this.tabPage3.Controls.Add(this.textBox6);
			this.tabPage3.Controls.Add(this.label17);
			this.tabPage3.Controls.Add(this.textBox5);
			this.tabPage3.Controls.Add(this.label16);
			this.tabPage3.Controls.Add(this.textBox4);
			this.tabPage3.Controls.Add(this.label15);
			this.tabPage3.Controls.Add(this.textBox3);
			this.tabPage3.Controls.Add(this.label14);
			this.tabPage3.Controls.Add(this.textBox2);
			this.tabPage3.Controls.Add(this.label13);
			this.tabPage3.Controls.Add(this.textBox1);
			this.tabPage3.Controls.Add(this.label12);
			this.tabPage3.Controls.Add(this.label11);
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Location = new System.Drawing.Point(4, 4);
			this.tabPage3.Size = new System.Drawing.Size(242, 239);
			this.tabPage3.Text = "Result";
			// 
			// lowicon
			// 
			this.lowicon.Image = ((System.Drawing.Image)(resources.GetObject("lowicon.Image")));
			this.lowicon.Location = new System.Drawing.Point(200, 80);
			this.lowicon.Size = new System.Drawing.Size(32, 32);
			this.lowicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.lowicon.Visible = false;
			// 
			// healthicon
			// 
			this.healthicon.Image = ((System.Drawing.Image)(resources.GetObject("healthicon.Image")));
			this.healthicon.Location = new System.Drawing.Point(200, 80);
			this.healthicon.Size = new System.Drawing.Size(32, 32);
			this.healthicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.healthicon.Visible = false;
			// 
			// highicon
			// 
			this.highicon.Image = ((System.Drawing.Image)(resources.GetObject("highicon.Image")));
			this.highicon.Location = new System.Drawing.Point(200, 80);
			this.highicon.Size = new System.Drawing.Size(32, 32);
			this.highicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.highicon.Visible = false;
			// 
			// veryhighicon
			// 
			this.veryhighicon.Image = ((System.Drawing.Image)(resources.GetObject("veryhighicon.Image")));
			this.veryhighicon.Location = new System.Drawing.Point(200, 80);
			this.veryhighicon.Size = new System.Drawing.Size(32, 32);
			this.veryhighicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.veryhighicon.Visible = false;
			// 
			// mediumicon
			// 
			this.mediumicon.Image = ((System.Drawing.Image)(resources.GetObject("mediumicon.Image")));
			this.mediumicon.Location = new System.Drawing.Point(200, 80);
			this.mediumicon.Size = new System.Drawing.Size(32, 32);
			this.mediumicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.mediumicon.Visible = false;
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular);
			this.label18.Location = new System.Drawing.Point(32, 80);
			this.label18.Size = new System.Drawing.Size(88, 20);
			this.label18.Text = "★BP Status：";
			// 
			// pb
			// 
			this.pb.Location = new System.Drawing.Point(120, 80);
			this.pb.Maximum = 5;
			this.pb.Size = new System.Drawing.Size(72, 16);
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular);
			this.textBox6.Location = new System.Drawing.Point(152, 208);
			this.textBox6.Size = new System.Drawing.Size(32, 21);
			this.textBox6.Text = "--";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular);
			this.label17.Location = new System.Drawing.Point(40, 208);
			this.label17.Size = new System.Drawing.Size(128, 20);
			this.label17.Text = "★Stroke in 10 yr.：";
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular);
			this.textBox5.Location = new System.Drawing.Point(128, 184);
			this.textBox5.Size = new System.Drawing.Size(32, 21);
			this.textBox5.Text = "--";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular);
			this.label16.Location = new System.Drawing.Point(24, 184);
			this.label16.Size = new System.Drawing.Size(112, 20);
			this.label16.Text = "▲CVD in 10 yr.：";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular);
			this.textBox4.Location = new System.Drawing.Point(112, 160);
			this.textBox4.Size = new System.Drawing.Size(48, 21);
			this.textBox4.Text = "--";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular);
			this.label15.Location = new System.Drawing.Point(24, 160);
			this.label15.Size = new System.Drawing.Size(96, 20);
			this.label15.Text = "▲Heart Age：";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular);
			this.textBox3.Location = new System.Drawing.Point(120, 136);
			this.textBox3.Size = new System.Drawing.Size(32, 21);
			this.textBox3.Text = "--";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular);
			this.label14.Location = new System.Drawing.Point(24, 136);
			this.label14.Size = new System.Drawing.Size(104, 20);
			this.label14.Text = "▲AF in 10 yr.：";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular);
			this.textBox2.Location = new System.Drawing.Point(80, 56);
			this.textBox2.Size = new System.Drawing.Size(136, 21);
			this.textBox2.Text = "--";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular);
			this.label13.Location = new System.Drawing.Point(24, 56);
			this.label13.Size = new System.Drawing.Size(56, 20);
			this.label13.Text = "▲BP：";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular);
			this.textBox1.Location = new System.Drawing.Point(80, 32);
			this.textBox1.Size = new System.Drawing.Size(48, 21);
			this.textBox1.Text = "--";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular);
			this.label12.Location = new System.Drawing.Point(24, 32);
			this.label12.Size = new System.Drawing.Size(56, 20);
			this.label12.Text = "▲BMI：";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular);
			this.label11.Location = new System.Drawing.Point(16, 112);
			this.label11.Size = new System.Drawing.Size(144, 20);
			this.label11.Text = "◆Advanced Analysis：";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular);
			this.label10.Location = new System.Drawing.Point(16, 8);
			this.label10.Text = "◆Basic：";
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.label19.Location = new System.Drawing.Point(152, 136);
			this.label19.Size = new System.Drawing.Size(24, 16);
			this.label19.Text = "%";
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.label20.Location = new System.Drawing.Point(160, 184);
			this.label20.Size = new System.Drawing.Size(24, 16);
			this.label20.Text = "%";
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular);
			this.label21.Location = new System.Drawing.Point(184, 208);
			this.label21.Size = new System.Drawing.Size(24, 16);
			this.label21.Text = "%";
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(250, 264);
			this.Controls.Add(this.tabControl1);
			this.Menu = this.mainMenu1;
			this.Text = "CVD Analysis System";

		}
		#endregion

		/// <summary>
		/// 應用程式的主進入點。
		/// </summary>

		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void label1_ParentChanged(object sender, System.EventArgs e)
		{
			lowicon.Visible=false;
			healthicon.Visible=false;
			mediumicon.Visible=false;
			highicon.Visible=false;
			veryhighicon.Visible=false;

			double  bmi;
			double sbp_n,dbp_n,age_n,pr_n,waist_n;
			sbp_n=double.Parse(sbp.Value.ToString());
			dbp_n=double.Parse(dbp.Value.ToString());
			age_n=double.Parse(age.Value.ToString());
			pr_n=double.Parse(pr.Value.ToString());
			waist_n=double.Parse(waist.Value.ToString());
			bmi=(double.Parse(weight.Value.ToString())/(double.Parse(height.Value.ToString())/100*double.Parse(height.Value.ToString())/100));
			textBox1.Text=bmi.ToString();
			//BMI calculate

			if(sbp_n<120 && dbp_n<80)
			{
				textBox2.Text="Normal";
				pb.Value=0;
				healthicon.Visible=true;
			}
			else if(((sbp_n>=120 && sbp_n<140) && dbp_n<90) ||(sbp_n<140 && (dbp_n>=80 &&dbp_n<90)) )
			{
				textBox2.Text="Prehypertension";
				pb.Value=1;
				lowicon.Visible=true;
			}
			else if(((sbp_n>=140 && sbp_n<160) && dbp_n<100) ||(sbp_n<160 && (dbp_n>=90 &&dbp_n<100)) )
			{
				textBox2.Text="Hypertension stage-1";
				pb.Value=2;
				mediumicon.Visible=true;
			}
			else if(((sbp_n>=160 && sbp_n<180) && dbp_n<110) ||(sbp_n<180 && (dbp_n>=100 &&dbp_n<110)) )
			{
				textBox2.Text="Hypertension stage-2";
				pb.Value=3;
				highicon.Visible=true;
			}
			else if(((sbp_n>=160 && sbp_n<180) && dbp_n<110) ||(sbp_n<180 && (dbp_n>=100 &&dbp_n<110)) && bmi>30)
			{
				textBox2.Text="Hypertension stage-2";
				pb.Value=3;
				veryhighicon.Visible=true;
			}
			//Blood pressure calculate

			double sum1=10.78552858 , sum2,sex_n,treat_n,heart_f_n,murmur_n,db_n,smoke_n,lvh_n,history_n;
			if(sex.Text=="male")
				sex_n=1; //gender
			else
				sex_n=0;
			if(treat.CheckState==System.Windows.Forms.CheckState.Checked)
				treat_n=1; //treat for hypertension
			else
				treat_n=0;
			if(heart_f.CheckState==System.Windows.Forms.CheckState.Checked)
				heart_f_n=1; //pre heart failure
			else
				heart_f_n=0;
			if(murmur.CheckState==System.Windows.Forms.CheckState.Checked)
				murmur_n=1; //significant murmur
			else
				murmur_n=0;
			if(db.CheckState==System.Windows.Forms.CheckState.Checked)
				db_n=1; //Diabetes
			else
				db_n=0;
			if(smoke.CheckState==System.Windows.Forms.CheckState.Checked)
				smoke_n=1; //Smoke
			else
				smoke_n=0;
			if(lvh.CheckState==System.Windows.Forms.CheckState.Checked)
				lvh_n=1; //lvh
			else
				lvh_n=0;
			if(history.CheckState==System.Windows.Forms.CheckState.Checked)
				history_n=1;  //Medical History
			else
				history_n=0;

			sum2=sex_n*1.994060+age_n*0.150520+bmi*0.019300+sbp_n*0.006150+treat_n*0.424100+(pr_n*0.070650)/10+murmur_n*3.795860+heart_f_n*9.428330+age_n*age_n*(-0.000380)+age_n*age_n*sex_n*(-0.000280)+age_n*murmur_n*(-0.042380)+age_n*heart_f_n*(-0.123070);			;
			double af;
			af=1-(Math.Pow(0.96337,Math.Exp(sum2-sum1)));
			if(af>0.3)
				af=0.3;
			af=af*100;
			textBox3.Text=af.ToString(); //AF Result

			double hdl_n,total_n,hpoint;
			int dbscore;
			hdl_n=double.Parse(hdl.Value.ToString());
			total_n=double.Parse(total.Value.ToString());
			dbscore=0;
			if(age_n>=45 && age_n<=54)
				dbscore+=2;
			else if(age_n>=55 && age_n<=64)
				dbscore+=3;
    
			if(bmi>=25 && bmi<=30)
				dbscore+=1;
			else if(bmi>30)
				dbscore+=3;

			if(sex_n==1)
			{
				if(waist_n>=94 && waist_n<102)
					dbscore+=3;
				else if(waist_n>=102)
					dbscore+=4;
			}
			else if(sex_n==0)
			{
				if(waist_n>=80 && waist_n<88)
					dbscore+=3;
				else if(waist_n>=88)
					dbscore+=4;
			}
  
			if(treat_n==1)
				dbscore+=2;
			if(history_n==1)
				dbscore+=5;
			//Calculate DB score
  
			if(db_n==0 && (dbscore>=9 && dbscore<13))
				db_n=0.053;
			else if(db_n==0 && (dbscore>=13 && dbscore<=20))
				db_n=0.253;
			
			hpoint=0;
			if(sex_n==1)
			{
				if(age_n>=35 && age_n<=39)
					hpoint+=2;
				else if(age_n>=40 && age_n<=44)
					hpoint+=5;
				else if(age_n>=45 && age_n<=49)
					hpoint+=6;
				else if(age_n>=50 && age_n<=54)
					hpoint+=8;
				else if(age_n>=55 && age_n<=59)
					hpoint+=10;
				else if(age_n>=60 && age_n<=64)
					hpoint+=11;
				else if(age_n>=65 && age_n<=69)
					hpoint+=12;
				else if(age_n>=70 && age_n<=74)
					hpoint+=14;
				else if(age_n>=75)
					hpoint+=15;
    
				if(hdl_n>=60)
					hpoint-=2;
				else if(hdl_n>=50 && hdl_n<=59)
					hpoint-=1;
				else if(hdl_n>=35 && hdl_n<=44)
					hpoint+=1;
				else if(hdl_n<=35)
					hpoint+=2;
    
				if(total_n>=160 && total_n<=199)
					hpoint+=1;
				else if(total_n>=200 && total_n<=239)
					hpoint+=2;
				else if(total_n>=240 && total_n<=279)
					hpoint+=3;
				else if(total_n>=280)
					hpoint+=4;
  
				hpoint+=(smoke_n*4);
				hpoint+=(db_n*3);
  
				if(treat_n==1)
				{
				if(sbp_n>=120 && sbp_n<=129)
					hpoint+=2;
				else if(sbp_n>=130 && sbp_n<=139)
					hpoint+=3;
				else if(sbp_n>=140 && sbp_n<=159)
					hpoint+=4;
				else if(sbp_n>=160)
					hpoint+=5;
				}
				else
				{
				if (sbp_n<=120)
					hpoint-=2;
				else if(sbp_n>=120 && sbp_n<=129)
					hpoint+=0;
				else if(sbp_n>=130 && sbp_n<=139)
					hpoint+=1;
				else if(sbp_n>=140 && sbp_n<=159)
					hpoint+=2;
				else if(sbp_n>=160)
					hpoint+=3;
				}
    
				if(hpoint<0)
					hage=-1;
				else if(hpoint==0)
					hage=30;
				else if(hpoint==1)
					hage=32;
				else if(hpoint==2)
					hage=34;
				else if(hpoint==3)
					hage=36;
				else if(hpoint==4)
					hage=38;
				else if(hpoint==5)
					hage=40;
				else if(hpoint==6)
					hage=42;
				else if(hpoint==7)
					hage=45;
				else if(hpoint==8)
					hage=48;
				else if(hpoint==9)
					hage=51;
				else if(hpoint==10)
					hage=54;
				else if(hpoint==11)
					hage=57;
				else if(hpoint==12)
					hage=60;
				else if(hpoint==13)
					hage=64;
				else if(hpoint==14)
					hage=68;
				else if(hpoint==15)
					hage=72;
				else if(hpoint==16)
					hage	=76;
				else if(hpoint>=17)
					hage=80;
			}
			else if(sex_n==0)
			{
				 if(age_n>=34 && age_n<=39)
					hpoint+=2;
				else if(age_n>=40 && age_n<=44)
					hpoint+=4;
				else if(age_n>=45 && age_n<=49)
					hpoint+=5;
				else if(age_n>=50 && age_n<=54)
					hpoint+=7;
				else if(age_n>=55 && age_n<=59)
					hpoint+=8;
				else if(age_n>=60 && age_n<=64)
					hpoint+=9;
				else if(age_n>=65 && age_n<=69)
					hpoint+=10;
				else if(age_n>=70 && age_n<=74)
					hpoint+=11;
				else if(age_n>=75)
					hpoint+=12;
    
				if(hdl_n>=60)
					hpoint-=2;
				else if(hdl_n>=50 && hdl_n<=59)
					hpoint-=1;
				else if(hdl_n>=35 && hdl_n<=44)
					hpoint+=1;
				else if(hdl_n<=35)
					hpoint+=2;
    
				if(total_n>=160 && total_n<=199)
					hpoint+=1;
				else if(total_n>=200 && total_n<=239)
					hpoint+=3;
				else if(total_n>=240 && total_n<=279)
					hpoint+=4;
				else if(total_n>=280)
					hpoint+=5;
  
				hpoint+=(smoke_n*4);
				hpoint+=(db_n*3);
  
				if(treat_n==1)
				{
					if(sbp_n>=120 && sbp_n<=129)
						hpoint+=2;
					else if(sbp_n>=130 && sbp_n<=139)
						hpoint+=3;
					else if(sbp_n>=140 && sbp_n<=159)
						hpoint+=5;
					else if(sbp_n>=160)
						hpoint+=6;
				}
				else
				{
					if (sbp_n<=120)
						hpoint-=2;
					else if(sbp_n>=120 && sbp_n<=129)
						hpoint+=0;
					else if(sbp_n>=130 && sbp_n<=139)
						hpoint+=1;
					else if(sbp_n>=140 && sbp_n<=149)
						hpoint+=2;
					else if(sbp_n>=150 && sbp_n<=159)
						hpoint+=4;
					else if(sbp_n>=160)
						hpoint+=5;
				}
				if(hpoint<1)
					hage=-1;
				else if(hpoint==1)
					hage=31;
				else if(hpoint==2)
					hage=34;
				else if(hpoint==3)
					hage=36;
				else if(hpoint==4)
					hage=39;
				else if(hpoint==5)
					hage=42;
				else if(hpoint==6)
					hage=45;
				else if(hpoint==7)
					hage=48;
				else if(hpoint==8)
					hage=51;
				else if(hpoint==9)
					hage=55;
				else if(hpoint==10)
					hage=59;
				else if(hpoint==11)
					hage=64;
				else if(hpoint==12)
					hage=68;
				else if(hpoint==13)
					hage=73;
				else if(hpoint==14)
					hage=79;
				else if(hpoint>=15)
					hage=80;
			} //
			if(hage==-1)
				textBox4.Text="30";
			else
				textBox4.Text=hage.ToString();//Heart Age

			if(sex_n==1)  //male
			{
				sum1=23.9802;
				if(treat_n==0)
					sum2=3.06117*Math.Log(age_n)+1.1237*Math.Log(total_n)-0.93263*Math.Log(hdl_n)+1.93303*Math.Log(sbp_n)+0.65451*smoke_n+0.57367*db_n;
				else if(treat_n==1)
					sum2=3.06117*Math.Log(age_n)+1.1237*Math.Log(total_n)-0.93263*Math.Log(hdl_n)+1.99881*Math.Log(sbp_n)+0.65451*smoke_n+0.57367*db_n;
				cvd=1-(Math.Pow(0.88936,Math.Exp(sum2-sum1)));
			}
			else if(sex_n==0)  //female
			{
				sum1=26.1931;
				if(treat_n==0)
					sum2=2.32888*Math.Log(age_n)+1.20904*Math.Log(total_n)-0.70833*Math.Log(hdl_n)+2.76157*Math.Log(sbp_n)+0.52873*smoke_n+0.69154*db_n;
				else if(treat_n==1)
					sum2=2.32888*Math.Log(age_n)+1.20904*Math.Log(total_n)-0.70833*Math.Log(hdl_n)+2.82263*Math.Log(sbp_n)+0.52873*smoke_n+0.69154*db_n;
				cvd=1-(Math.Pow(0.95012,Math.Exp(sum2-sum1)));
			}
			cvd=cvd*100;
			textBox5.Text=cvd.ToString(); //cvd result

			stroke=0;
			if(sex_n==1)  //male
			{
				//Age Factor
				if(age_n>=57 && age_n<=59)
					stroke+=1;
				else if(age_n>=60 && age_n<=62)
					stroke+=2;
				else if(age_n>=63 && age_n<=65)
					stroke+=3;
				else if(age_n>=66 && age_n<=68)
					stroke+=4;
				else if(age_n>=69 && age_n<=72)
					stroke+=5;
				else if(age_n>=73 && age_n<=75)
					stroke+=6;
				else if(age_n>=76 && age_n<=78)
					stroke+=7;
				else if(age_n>=79 && age_n<=81)
					stroke+=8;
				else if(age_n>=82 && age_n<=84)
					stroke+=9;
				else if(age_n>=85)
					stroke+=10;
    
				//SBP Factor  
				if(treat_n==1)
				{
					if(sbp_n>=106 && sbp_n<=112)
					{
						stroke+=1;
					}
					else if(sbp_n>=113 && sbp_n<=117)
					{
						stroke+=2;
					}
					else if(sbp_n>=118 && sbp_n<=123)
					{
						stroke+=3;
					}
					else if(sbp_n>=124 && sbp_n<=129)
					{
						stroke+=4;
					}
					else if(sbp_n>=130 && sbp_n<=135)
					{
						stroke+=5;
					}
					else if(sbp_n>=136 && sbp_n<=142)
					{
						stroke+=6;
					}
					else if(sbp_n>=143 && sbp_n<=150)
					{
						stroke+=7;
					}
					else if(sbp_n>=151 && sbp_n<=161)
					{
						stroke+=8;
					}
					else if(sbp_n>=162 && sbp_n<=176)
					{
						stroke+=9;
					}
					else if(sbp_n>=177)
					{
						stroke+=10;
					}
				}
				else if(treat_n==0)
				{
					if(sbp_n>=106 && sbp_n<=115)
					{
						stroke+=1;
					}
					else if(sbp_n>=116 && sbp_n<=125)
					{
						stroke+=2;
					}
					else if(sbp_n>=126 && sbp_n<=135)
					{
						stroke+=3;
					}
					else if(sbp_n>=136 && sbp_n<=145)
					{
						stroke+=4;
					}
					else if(sbp_n>=146 && sbp_n<=155)
					{
						stroke+=5;
					}
					else if(sbp_n>=156 && sbp_n<=165)
					{
						stroke+=6;
					}
					else if(sbp_n>=166 && sbp_n<=175)
					{
						stroke+=7;
					}
					else if(sbp_n>=176 && sbp_n<=185)
					{
						stroke+=8;
					}
					else if(sbp_n>=186 && sbp_n<=195)
					{
						stroke+=9;
					}
					else if(sbp_n>=196)
					{
						stroke+=10;
					}
				}
    
				//Other Factors
				//stroke+=(db_n*2);
				stroke+=(smoke_n*3);
				stroke+=(cvd*4/100);
				stroke+=(af*4/100);
				stroke+=(lvh_n*5);
				if(db_n==1)
					stroke+=(db_n*2);
				//else if(db_n==0 && (db_nscore>=9 && db_nscore<20))
				//stroke+=1;
    
    
				//result catalog
				per=0;
				if(stroke>=1 && stroke<3)
					per=3;
				else if(stroke>=3 && stroke<5)
					per=4;
				else if(stroke>=5 && stroke<7)
					per=5;
				else if(stroke>=7 && stroke<8)
					per=6;
				else if(stroke>=8 && stroke<9)
					per=7;
				else if(stroke>=9 && stroke<10)
					per=8;
				else if(stroke>=10 && stroke<11)
					per=10;
				else if(stroke>=11 && stroke<12)
					per=11;
				else if(stroke>=12 && stroke<13)
					per=13;
				else if(stroke>=13 && stroke<14)
					per=15;
				else if(stroke>=14 && stroke<15)
					per=17;
				else if(stroke>=15 && stroke<16)
					per=20;
				else if(stroke>=16 && stroke<17)
					per=22;
				else if(stroke>=17 && stroke<18)
					per=26;
				else if(stroke>=18 && stroke<19)
					per=29;
				else if(stroke>=19 && stroke<20)
					per=33;
				else if(stroke>=20 && stroke<21)
					per=37;
				else if(stroke>=21 && stroke<22)
					per=42;
				else if(stroke>=22 && stroke<23)
					per=47;
				else if(stroke>=23 && stroke<24)
					per=52;
				else if(stroke>=24 && stroke<25)
					per=57;
				else if(stroke>=25 && stroke<26)
					per=63;
				else if(stroke>=26 && stroke<27)
					per=68;
				else if(stroke>=27 && stroke<28)
					per=74;
				else if(stroke>=28 && stroke<29)
					per=79;
				else if(stroke>=29 && stroke<30)
					per=84;
				else if(stroke>=30)
					per=88;
			}
			else if(sex_n==0)  //female
			{
				//Age Factor
				if(age_n>=57 && age_n<=59)
					stroke+=1;
				else if(age_n>=60 && age_n<=62)
					stroke+=2;
				else if(age_n>=63 && age_n<=64)
					stroke+=3;
				else if(age_n>=65 && age_n<=67)
					stroke+=4;
				else if(age_n>=68 && age_n<=70)
					stroke+=5;
				else if(age_n>=71 && age_n<=73)
					stroke+=6;
				else if(age_n>=74 && age_n<=76)
					stroke+=7;
				else if(age_n>=77 && age_n<=78)
					stroke+=8;
				else if(age_n>=79 && age_n<=81)
					stroke+=9;
				else if(age_n>=82)
					stroke+=10;
    
				//SBP Factor  
				if(treat_n==1)
				{
					if(sbp_n>=95 && sbp_n<=106)
					{
						stroke+=1;
					}
					else if(sbp_n>=107 && sbp_n<=113)
					{
						stroke+=2;
					}
					else if(sbp_n>=114 && sbp_n<=119)
					{
						stroke+=3;
					}
					else if(sbp_n>=120 && sbp_n<=125)
					{
						stroke+=4;
					}
					else if(sbp_n>=126 && sbp_n<=131)
					{
						stroke+=5;
					}
					else if(sbp_n>=132 && sbp_n<=139)
					{
						stroke+=6;
					}
					else if(sbp_n>=140 && sbp_n<=148)
					{
						stroke+=7;
					}
					else if(sbp_n>=149 && sbp_n<=160)
					{
						stroke+=8;
					}
					else if(sbp_n>=161 && sbp_n<=204)
					{
						stroke+=9;
					}
					else if(sbp_n>=205)
					{
						stroke+=10;
					}
				}
				else if(treat_n==0)
				{
					if(sbp_n>=95 && sbp_n<=106)
					{
						stroke+=1;
					}
					else if(sbp_n>=107 && sbp_n<=118)
					{
						stroke+=2;
					}
					else if(sbp_n>=119 && sbp_n<=130)
					{
						stroke+=3;
					}
					else if(sbp_n>=131 && sbp_n<=143)
					{
						stroke+=4;
					}
					else if(sbp_n>=144 && sbp_n<=155)
					{
						stroke+=5;
					}
					else if(sbp_n>=156 && sbp_n<=167)
					{
						stroke+=6;
					}
					else if(sbp_n>=168 && sbp_n<=180)
					{
						stroke+=7;
					}
					else if(sbp_n>=181 && sbp_n<=192)
					{
						stroke+=8;
					}
					else if(sbp_n>=193 && sbp_n<=204)
					{
						stroke+=9;
					}
					else if(sbp_n>=205)
					{
						stroke+=10;
					}
				}
    
				//Other Factors
				//stroke+=(db_n*3);
				stroke+=(smoke_n*3);
				stroke+=(cvd*2/100);
				stroke+=(af*6/100);
				stroke+=(lvh_n*4);
				if(db_n==1)
					stroke+=(db_n*3);
					//else if(db_n==0 &&(db_nscore>=9 && db_nscore<13))
					//stroke+=1;
				else if(db_n==0 &&(dbscore>=13 && dbscore<=20))
					stroke+=1;
    
				//result catalog
				per=0;
				if(stroke>=1 && stroke<3)
					per=1;
				else if(stroke>=3 && stroke<6)
					per=2;
				else if(stroke>=6 && stroke<7)
					per=3;
				else if(stroke>=7 && stroke<9)
					per=4;
				else if(stroke>=9 && stroke<10)
					per=5;
				else if(stroke>=10 && stroke<11)
					per=6;
				else if(stroke>=11 && stroke<12)
					per=8;
				else if(stroke>=12 && stroke<13)
					per=9;
				else if(stroke>=13 && stroke<14)
					per=11;
				else if(stroke>=14 && stroke<15)
					per=13;
				else if(stroke>=15 && stroke<16)
					per=16;
				else if(stroke>=16 && stroke<17)
					per=19;
				else if(stroke>=17 && stroke<18)
					per=23;
				else if(stroke>=18 && stroke<19)
					per=27;
				else if(stroke>=19 && stroke<20)
					per=32;
				else if(stroke>=20 && stroke<21)
					per=37;
				else if(stroke>=21 && stroke<22)
					per=43;
				else if(stroke>=22 && stroke<23)
					per=50;
				else if(stroke>=23 && stroke<24)
					per=57;
				else if(stroke>=24 && stroke<25)
					per=64;
				else if(stroke>=25 && stroke<26)
					per=71;
				else if(stroke>=26 && stroke<27)
					per=78;
				else if(stroke>=27)
					per=84;
			}
			textBox6.Text=per.ToString();
		}
	}

}
