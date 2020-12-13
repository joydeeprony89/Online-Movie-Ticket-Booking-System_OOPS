using System;
using System.Collections.Generic;

namespace Online_Movie_Ticket_Booking_System_OOPS
{
    class MovieTicketBookingSystem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public enum BookingStatus
        {
            booked,
            cancelled,
            hold
        }

        public enum PaymentStatus
        {
            done,
            inprocess,
            calcelled
        }
        public enum SeatingType
        {
            firstclass,
            secondclass,
            sofa
        }
        public enum AccountStatus
        {
            blocked,
            active
        }

        public class Address
        {
            string houseno;
            string pincode;
        }

        public class Account
        {
            string id;
            string password;
            AccountStatus status;

            bool resetpassowrd();
        }

        public abstract class Person
        {
            string name;
            int age;
            string email;
            int phoneno;
            Address address;
            Account Account;
        }

        public class Customer : Person
        {
            List<Booking> AvailableBookings();
            bool book(Show show);
        }

        public class Admin : Person
        {
            bool AddCinema(Cinema cinema);
            bool AddHall(CinemaHall cinemaHall);
            bool AddMovie(Movie movie);
            bool AddShow(Show show);

            bool BlockUser(Account account);
            bool UnBlockUser(Account account);
        }

        public class Movie
        {
            string name;
            DateTime releasedate;
            int rating;
            int watching;
            List<Show> shows;
            List<Movie> GetMovies();
        }

        public class Show
        {
            int id;
            Movie Movie;
            List<ShowTime> showTimes;
            ShowSeat seat;
        }

        public class ShowTime
        {
            DateTime start;
            DateTime end;
        }

        public class City
        {
            Address address;
        }

        public class Cinema
        {
            string name;
            City city;
            List<CinemaHall> halls;
        }

        public class CinemaHall
        {
            int id;
            List<Show> shows;
            List<CinemaHallSeat> cinemaHallSeats;
        }

        public class CinemaHallSeat
        {
            int row;
            int column;
            List<ShowSeat> showSeats;
            SeatingType seatingType;
        }

        public class ShowSeat
        {
            double price;
            int seatNo;
            bool available;
        }

        public class Booking
        {
            int nnofoseats;
            List<ShowSeat> seats;
            int id;
            DateTime bookingdate;
            BookingStatus status;
            Show show;
            Payment payment;

            bool MakePayment(Payment payment);
            bool cancel(Booking booking);
            bool AssignSeat(List<ShowSeat> seats);
        }

        public class Payment
        {
            int id;
            PaymentStatus status;

            bool AddCoupon(Coupon coupon);
        }

        public class Coupon
        {
            string code;
            double discount;
        }

        public class Notification
        {
            int id;
            string content;

            bool sendNotification(Account account);
        }
    }
}
