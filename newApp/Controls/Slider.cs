// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// using System.Windows.Forms;
// using System.Drawing;
// using System.Drawing.Drawing2D;
// using System.ComponentModel;
// using NAudio.Gui;

// namespace newApp.Controls
// {
//     public enum TextPosition
//     {
//         Left,
//         Right,
//         Center,
//         Sliding,
//         None
//     }
//     class BKSlider : NAudio.Gui.VolumeSlider
//     {
// 		private Color channelColor = Color.White;
// 		private Color sliderColor = Color.Black;
// 		private Color forbackColor = Color.Black;
// 		private int channelHeight = 6;
// 		private int sliderHeight = 6;
// 		private TextPosition showValue = TextPosition.Right;

// 		private bool paintedBack = false; 
// 		private bool stopPainting = false;


// 		public BKSlider()
// 		{
// 			this.SetStyle(ControlStyles.UserPaint, true);
// 			this.ForeColor = Color.White;
// 		}
// 		[Category("Salman")]
//         public Color ChannelColor 
//         {
//             get => channelColor;
//             set 
//             { 
// 				channelColor = value;
//                 this.Invalidate(); 
//             }
//         }
// 		[Category("Salman")]
//         public Color SliderColor 
// 		{
// 			get => sliderColor;
// 			set  
// 			{
// 				sliderColor = value; 
// 				this.Invalidate(); 
// 			} 
// 		}
// 		[Category("Salman")]
//         public Color ForbackColor 
// 		{
// 			get => forbackColor;
// 			set 
// 			{
// 				forbackColor = value;
// 				this.Invalidate();
// 			}
// 		}
// 		[Category("Salman")]
//         public int ChannelHeight 
// 		{
// 			get => channelHeight;
// 			set 
// 			{
// 				channelHeight = value;
// 			 	this.Invalidate();
// 			}
// 		}
// 		[Category("Salman")]
//         public int SliderHeight 
// 		{ 
// 			get => sliderHeight; 
// 			set 
// 			{
// 				sliderHeight = value;
// 			 	this.Invalidate();
// 			} 
// 		}
// 		[Category("Salman")]
//         public TextPosition ShowValue 
// 		{
// 			get => showValue;
// 			 set 
// 			{
// 				showValue = value;
// 			 	this.Invalidate();
// 			}
// 		}
// 		[Category("Salman")]
//         public bool PaintedBack 
// 		{ 
// 			get => paintedBack; 
// 			set 
// 			{
// 				paintedBack = value;
// 			 	this.Invalidate();
// 			} 
// 		}
// 		[Category("Salman")]
//         public bool StopPainting 
// 		{ 
// 			get => stopPainting; 
// 			set 
// 			{
// 				stopPainting = value;
// 			 	this.Invalidate();
// 			} 
// 		}
// 		[Category("Salman")]
// 		[Browsable(true)]
// 		[EditorBrowsable(EditorBrowsableState.Always)]
// 		public override Font Font
// 		{
// 			get => base.Font;
// 			set
// 			{
// 				base.Font = value;
// 				this.Invalidate();
// 			}

// 		}
// 		// public override Color ForeColor
// 		// {
// 		// 	get => base.ForeColor;
// 		// 	set {
// 		// 		base.ForeColor;
// 		// 		this.Invalidate();
// 		// 	}
// 		// }

// 		protected override void OnPaintBackGround(PaintEventArgs e)
// 		{
// 			if(stopPainting == false)
// 			{
// 				if(paintedBack == false)
// 				{
// 					Graphics g = e.Graphics;
// 					Rectangle rect = new Rectangle(0, 0, this.Width, ChannelHeight);
// 					using(var brushChannel = new SolidBrush(ChannelColor))
// 					{
// 						if(channelHeight >= sliderHeight)
// 							rect.Y = this.Height - channelHeight;

// 						else rect.Y = this.Height - ((channelHeight + sliderHeight) / 2);

// 						g.Clear(this.Parent.BackColor)
// 						g.FillRectangle(brushChannel, rect);

// 						if(this.DesignMode == false)
// 							paintedBack = true;
// 					}
// 				}
// 			}


// 		}
//     }

// }
