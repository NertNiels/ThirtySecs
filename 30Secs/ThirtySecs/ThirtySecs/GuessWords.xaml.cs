using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SkiaSharp;
using SkiaSharp.Views.Forms;
using System.Diagnostics;

namespace ThirtySecs
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GuessWords : ContentPage
	{
        double time;
        Stopwatch watch = new Stopwatch();

		public GuessWords ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);

            TimerSetup();
        }

        void TimerSetup()
        {
            var fps = TimeSpan.FromSeconds(1.0 / 30.0);

            watch.Start();

            Device.StartTimer(fps, () =>
            {
                time = watch.Elapsed.TotalSeconds;

                timerCanvas.InvalidateSurface();

                if (time >= 30)
                {
                    title.Text = "Time's up!";
                    title.TextColor = Color.Red;
                    return false;
                }

                return true;
            });
        }

        void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();

            SKPaint paint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = Color.White.ToSKColor(),
                StrokeWidth = info.Width*0.07f,
            };

            SKRect rect = new SKRect(info.Width * 0.1f, -info.Height*0.9f, info.Width * 1.9f, info.Height * 0.9f);
            float startAngle = 180f;
            float sweepAngle = -90+((float)time*3);

            using(SKPath path = new SKPath())
            {
                path.AddArc(rect, startAngle, sweepAngle);
                canvas.DrawPath(path, paint);
            }

            //canvas.DrawCircle(info.Width, 0, info.Width-paint.StrokeWidth, paint);

            

            SKPaint textPaint = new SKPaint
            {
                Style = SKPaintStyle.Stroke,
                Color = Color.White.ToSKColor(),
                TextSize = info.Width*0.55f,
                IsStroke = false,
                IsAntialias = true,

                TextAlign = SKTextAlign.Right
                
                
            };

            SKPoint textP = new SKPoint
            {
                X = info.Width * 0.9f,
                Y = textPaint.FontMetrics.CapHeight + info.Height * 0.1f

            };


            canvas.DrawText(Math.Round(30-time, 0).ToString(), textP, textPaint);
        }

        private void Word1_Clicked(object sender, EventArgs e)
        {
            if(word1.TextColor == Color.White)  word1.TextColor = Color.Green;
            else word1.TextColor = Color.White;
        }

        private void Word2_Clicked(object sender, EventArgs e)
        {
            if (word2.TextColor == Color.White) word2.TextColor = Color.Green;
            else word2.TextColor = Color.White;
        }

        private void Word3_Clicked(object sender, EventArgs e)
        {
            if (word3.TextColor == Color.White) word3.TextColor = Color.Green;
            else word3.TextColor = Color.White;
        }

        private void Word4_Clicked(object sender, EventArgs e)
        {
            if (word4.TextColor == Color.White) word4.TextColor = Color.Green;
            else word4.TextColor = Color.White;
        }

        private void Word5_Clicked(object sender, EventArgs e)
        {
            if (word5.TextColor == Color.White) word5.TextColor = Color.Green;
            else word5.TextColor = Color.White;
        }
    }
}