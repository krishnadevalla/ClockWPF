using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Threading;

namespace Clock_WPF.ViewModel
{
    class MainPageViewModel: Common.BindableBase
    {
        public MainPageViewModel()
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            timer.Tick += (s, e) =>
              {
                  this.SecondAngle = DateTime.Now.Second * (360 / 60);
                  this.MinuteAngle = DateTime.Now.Minute * (360 / 60);
                  this.HourAngle = DateTime.Now.Hour * (360 / 12);
              };
            timer.Start();
            for (int i = 0; i < 60; i++)
            {
                var second = new Models.Item
                {
                    Text = i.ToString(),
                    Angle=i*(360/60)
                };
                this.SecondTicks.Add(second);
            }
            for (int i = 0; i < 12; i++)
            {
                var hour = new Models.Item
                {
                    Text = (i == 0) ? "12" : i.ToString(),
                    Angle = i * (360 / 12)
                };
                this.HoursTicks.Add(hour);

            }
        }
        double _SecondAngle=default(double);
        public double SecondAngle{get { return _SecondAngle; }set { SetProperty(ref _SecondAngle, value); } }

        double _MinuteAngle = default(double);
        public double MinuteAngle { get { return _MinuteAngle; } set { SetProperty(ref _MinuteAngle, value); } }

        double _HourAngle = default(double);
        public double HourAngle { get { return _HourAngle; } set { SetProperty(ref _HourAngle, value); } }

        ObservableCollection<Models.Item> _SecondTicks = new ObservableCollection<Models.Item>();
        public ObservableCollection<Models.Item> SecondTicks { get { return _SecondTicks; } }

        ObservableCollection<Models.Item> _HoursTicks = new ObservableCollection<Models.Item>();
        public ObservableCollection<Models.Item> HoursTicks {get {return _HoursTicks; } }

    }
}
