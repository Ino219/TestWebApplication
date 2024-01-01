using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;


namespace TestWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static int index_;
        //初回処理フラグ
        public static bool firstFlg=true;

        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (firstFlg)
            {
                DataDisplay(index_);
                firstFlg = false;
            }
            
        }

        public void DataDisplay(int index)
        {

            //データ受け取り用のデータセットを作成
            DataSet1 ds1 = new DataSet1();
            //テーブルアダプターの定義
            var adapter = new DataSet1TableAdapters.TableTableAdapter();
            //テーブルの内容をデータセットに代入
            adapter.Fill(ds1.Table);
            //テーブルの行数を取得
            int rows = ds1.Table.Rows.Count;
            //各項目のデータを取得
            string id = ds1.Table.Rows[index].ItemArray[1].ToString();
            string name = (string)ds1.Table.Rows[index].ItemArray[0];
            string price = ds1.Table.Rows[index].ItemArray[2].ToString();
            string filepath = (string)ds1.Table.Rows[index].ItemArray[3];

            

            //各項目のデータを表示
            Label1.Text = "ID:" + id;
            Label2.Text = "商品名:" + name;
            Label3.Text = "単価:" + price;
            
            Image1.Width = 500;
            ImageButton1.Width = 150;
            ImageButton2.Width = 150;

            
            Image1.ImageUrl = filepath;
            
            

            //最初の項目
            if (index == 0)
            {
                ImageButton1.Visible = false;
                ImageButton2.Visible = true;
                
                
                string Nextfilepath = (string)ds1.Table.Rows[index + 1].ItemArray[3];
                ImageButton2.ImageUrl = Nextfilepath;
            }
            //最後の項目
            else if (index == rows - 1)
            {
                ImageButton2.Visible = false;
                string Backfilepath = (string)ds1.Table.Rows[index - 1].ItemArray[3];
                ImageButton1.ImageUrl = Backfilepath;
            }
            else
            {
                ImageButton2.Visible = true;
                ImageButton1.Visible = true;
                string Nextfilepath = (string)ds1.Table.Rows[index + 1].ItemArray[3];
                ImageButton2.ImageUrl = Nextfilepath;
                string Backfilepath = (string)ds1.Table.Rows[index - 1].ItemArray[3];
                ImageButton1.ImageUrl = Backfilepath;
            }
        }
        

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            index_ = index_ - 1;
            DataDisplay(index_);
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            index_++;
            DataDisplay(index_);
        }
    }
}