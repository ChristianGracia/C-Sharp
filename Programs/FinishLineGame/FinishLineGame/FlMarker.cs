namespace FinishLineGame
{
    public class FlMarker : Marker
    {
        public bool Stopped;
        // base(param) refers to parent class
        //access parent methods with base.Move
        //override to use child method with same name as parent

        public FlMarker(string name) : base(name)
        {
            this.Stopped = false;
        }
        public void Move(int spaces, int stopValue, Deck gameDeck)
        {
            for (int count = 1; count < spaces; count++)
            {
                if (gameDeck.Cards[this.Position + count].Value >= stopValue)
                {
                    Move(count);
                    return;
                }
            }
            this.Move(spaces);
        }
    }
}