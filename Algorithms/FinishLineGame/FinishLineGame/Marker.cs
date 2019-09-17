using System;

namespace FinishLineGame
{
    public class Marker
    {
        public int Position;
        public string Name;

        public Marker(string name)
        {
            this.Position = 0;
            this.Name = name;
        }

        public void Move(int spaces)
        {
            this.Position += spaces;
        }
    }

    public class FlMarker : Marker
    {
        public bool Stopped;
        // base(param) refers to parent class
        public FlMarker(string name) : base(name)
        {
            this.Stopped = false;

        }
    }
}