namespace FinishLineGame
{
    public class Player
    {
        public Marker[] Markers;
        public string Name;

        public Player(string name, string[] markerNames)
        {
            this.Markers = new Marker[markerNames.Length];
            this.Name = name;
         
            for(int markerName = 0; markerName < markerNames.Length; markerName++)
            {
                this.Markers[markerName] = new Marker (markerNames[markerName]);
            }
        }
    }
}