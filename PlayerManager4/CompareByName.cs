namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private readonly bool ascending;
        public CompareByName(bool ascending)
        {
            this.ascending = ascending;
        }
        public int Compare(Player x, Player y)
        {
            int result =string.Compare(x.name, y.name);

            if (!ascending)
                result *= -1;

            return result;
        }
    }
}