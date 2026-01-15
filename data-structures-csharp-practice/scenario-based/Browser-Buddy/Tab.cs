using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenariobased.BrowserBuddy
{
    internal class Tab
    {
        public BrowserHistory History { get; } = new BrowserHistory();

        public void Visit(string url) => History.Visit(url);
        public void Back() => History.Back();
        public void Forward() => History.Forward();
    }
}
