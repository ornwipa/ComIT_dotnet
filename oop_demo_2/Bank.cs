namespace oop_demo
{
    public class Bank
    {
        
    }

    public class BankMembership
    {
        public Person person { get; private set; }
        public Bank bank { get; private set; }
        public BankMembership(Person person, Bank bank)
        {
            this.bank = bank;
            this.person = person;
        }
    }
}