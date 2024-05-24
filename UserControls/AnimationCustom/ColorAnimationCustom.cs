using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace LearningUserControl.UserControls
{
    internal class ColorAnimationCustom : AnimationTimeline
    {
        public override Type TargetPropertyType => throw new NotImplementedException();

        protected override Freezable CreateInstanceCore()
        {
            return new ColorAnimationCustom();
        }
    }
}