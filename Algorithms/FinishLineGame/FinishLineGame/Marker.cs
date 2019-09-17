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

        public void Move()
        {

        }

        public static implicit operator Marker(string v)
        {
            throw new NotImplementedException();
        }
    }
}