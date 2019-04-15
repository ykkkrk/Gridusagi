using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Gridusagi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

            ///DisplayAlert("タイトル", ((ImageButton)sender).Source.ToString(), "OK");

            var sum = Add(100, 200);
            sum = Add(sum, sum);
            DisplayAlert("足し算したよ",sum.ToString(), "OK");
        }

        /// <summary>
        /// 足し算をする
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
