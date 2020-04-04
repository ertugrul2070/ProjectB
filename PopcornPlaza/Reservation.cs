namespace PopcornPlaza
{
    public class Reservation
    {
        private int reservationID;

        private int amountOfPeople;

        private string discountCode;

        private int totalAmountOfMoney;

        private cinimaRoom cinimaRoom;

        private Snack snack;

        private Customer customer;

        private movie movie;

        ///  
        public int getReservationID()
        {
            return 0;
        }

        public int getAmountOfPeople()
        {
            return 0;
        }

        public string getDiscountCode()
        {
            return null;
        }

        public bool checkDiscountCode()
        {
            return null;
        }

        public double calcultateTotalAmount()
        {
            return 0;
        }

        public string selectSnack()
        {
            return null;
        }

        public void checkAvailableSeats()
        {

        }

    }
}