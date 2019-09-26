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

        public string HasMarkersAt(int position)
        {
            string master = "";
            foreach (var marker in this.Markers)
            {
                if (marker.Position == position)
                {
                    master += marker.Name;
                }
                else
                {
                    master += " ";
                }
            }

            return master;
        }

        public int FindMarker(string query)
        {
            for (int counter = 0; counter < this.Markers.Length; counter++)
            {
                if (Markers[counter].Name == query)
                    return counter;
            }

            return -1;
        }
    }
}