namespace blogpessoal.Security
{
    public class Settings
    {
        private static string secret = "024f8292293abee99aab56e2eed3eb788180315652d5cfb7e0069b8ed84f6cba";

        public static string Secret { get => secret; set => secret = value; }
    }
}
