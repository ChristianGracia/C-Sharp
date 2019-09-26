namespace FinishLineGame
{
    public class FlMarker : Marker
    {
        public bool Stopped;

        public FlMarker(string name) : base(name)
        {
            this.Stopped = false;
        }
        public void Move(int spaces, int stopValue, Deck gameDeck)
        {
            for (int count = 1; count <= spaces; count++)
            {
                if (this.Position + count >= gameDeck.Cards.Count)
                    return;
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