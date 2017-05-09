namespace ChallengeMe
{
    internal enum AccountState
    {
        New,
        Active,
        UnderReview,
        Frozen,
        Closed
    };

    internal struct Account
    {
        public AccountState State;
        public string Name;
        public string Location;
        public int AccountNumber;
        public int CreatedChallenge;
        public int AcceptedChallenge;
    }

    internal class AccountStructureArray
    {
        public static void Main()
        {
            const int MAX_PLAYERS = 100;
            Account[] Player = new Account[MAX_PLAYERS];
            Player[0].Name = "Aura";
            Player[0].State = AccountState.Active;
            Player[0].CreatedChallenge = 20;
            Player[1].Name = "John";
            Player[1].State = AccountState.Frozen;
            Player[1].CreatedChallenge = 0;
        }
    }
}