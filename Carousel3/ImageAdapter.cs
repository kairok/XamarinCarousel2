using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace Carousel3
{
    public class ImageAdapter : PagerAdapter
    {
        private Context context;
        private int[] imageList =
        {
            Resource.Drawable.intro1,
            Resource.Drawable.intro2,
            Resource.Drawable.intro3
        };

        public ImageAdapter(Context context)
        {
            this.context = context;
        }

        public override int Count
        {
            get
            {
                return imageList.Length;
            }
        }

        public override bool IsViewFromObject(View view, Java.Lang.Object objectValue)
        {
            return view == ((ImageView)objectValue);
        }

        public override Java.Lang.Object InstantiateItem(View container, int position)
            {
                ImageView ImageView = new ImageView(context);
                ImageView.SetScaleType(ImageView.ScaleType.CenterCrop);
            ImageView.SetImageResource(imageList[position]);
            ((ViewPager)container).AddView(ImageView, 0);
            return ImageView;

            }

        public override void DestroyItem(View container, int position, Java.Lang.Object objectValue)
        {
            ((ViewPager)container).RemoveView((ImageView)objectValue);
        }


    }
}