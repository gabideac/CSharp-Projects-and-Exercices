using System;

namespace SupportCases
{
    public enum PriorityLevel
    {
        Critical,
        Important,
        Medium,
        Low
    }

    public struct SupportTicket
    {
        public long Id;
        public string Description;
        public PriorityLevel Priority;

        public SupportTicket(long id, string description, PriorityLevel priority)
        {
            this.Id = id;
            this.Description = description;
            this.Priority = priority;
        }
    }

    public class Program
    {
        public static void Quick3Sort(SupportTicket[] tickets)
        {
            int lessImportant = tickets.Length - 1;
            const int mostImoirtant = 0;
            Quick3Sort(tickets, mostImoirtant, lessImportant);
        }

        static void Main()
        {
            SupportTicket[] tickets = ReadSupportTickets();
            Quick3Sort(tickets);
            Print(tickets);
            Console.Read();
        }

        static void Quick3Sort(SupportTicket[] tickets, int mostImoirtant, int lessImportant)
        {
            if (mostImoirtant >= lessImportant)
            {
                return;
            }

            int i = 0;
            int j = 0;
            Partition(tickets, mostImoirtant, lessImportant, ref i, ref j);
            Quick3Sort(tickets, mostImoirtant, i);
            Quick3Sort(tickets, j, lessImportant);
        }

        private static void Partition(SupportTicket[] tickets, int mostImoirtant, int lessImportant, ref int i, ref int j)
        {
            if (lessImportant - mostImoirtant <= 1 && PriorityValue(tickets[lessImportant]) <= PriorityValue(tickets[mostImoirtant]))
                {
                    SwapTickets(ref tickets[lessImportant], ref tickets[mostImoirtant]);
                    i = mostImoirtant;
                    j = lessImportant;
                    return;
                }

            int mediumImportance = mostImoirtant;
            SupportTicket pivot = tickets[lessImportant];
            while (mediumImportance <= lessImportant)
            {
                if (PriorityValue(tickets[mediumImportance]) < PriorityValue(pivot))
                {
                    SwapTickets(ref tickets[mostImoirtant++], ref tickets[mediumImportance++]);
                }
                else if (PriorityValue(tickets[mediumImportance]) == PriorityValue(pivot))
                {
                    mediumImportance++;
                }
                else if (PriorityValue(tickets[mediumImportance]) > PriorityValue(pivot))
                {
                    SwapTickets(ref tickets[mediumImportance], ref tickets[lessImportant--]);
                }

                i = mostImoirtant - 1;
                j = mediumImportance;
            }
       }

        static void SwapTickets(ref SupportTicket first, ref SupportTicket second)
        {
            SupportTicket temp = first;
            first = second;
            second = temp;
        }

        static int PriorityValue(SupportTicket ticket)
        {
            const int critical = 1;
            const int important = 2;
            const int medium = 3;
            const int low = 4;
            switch (ticket.Priority)
            {
                case PriorityLevel.Critical:
                    return critical;
                case PriorityLevel.Important:
                    return important;
                case PriorityLevel.Medium:
                    return medium;
                case PriorityLevel.Low:
                    return low;
            }

            return 0;
        }

        static void Print(SupportTicket[] tickets)
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                Console.WriteLine(tickets[i].Id + " - " + tickets[i].Description + " - " + tickets[i].Priority);
            }
        }

        static SupportTicket[] ReadSupportTickets()
        {
            const int ticketIdIndex = 0;
            const int descriptionIndex = 1;
            const int priorityLevelIndex = 2;

            int ticketsNumber = Convert.ToInt32(Console.ReadLine());
            SupportTicket[] result = new SupportTicket[ticketsNumber];

            for (int i = 0; i < ticketsNumber; i++)
            {
                string[] ticketData = Console.ReadLine().Split('-');
                long id = Convert.ToInt64(ticketData[ticketIdIndex]);
                result[i] = new SupportTicket(id, ticketData[descriptionIndex].Trim(), GetPriorityLevel(ticketData[priorityLevelIndex]));
            }

            return result;
        }

        static PriorityLevel GetPriorityLevel(string priority)
        {
            return priority.ToLower().Trim() switch
            {
                "critical" => PriorityLevel.Critical,
                "important" => PriorityLevel.Important,
                "medium" => PriorityLevel.Medium,
                _ => PriorityLevel.Low,
            };
        }
    }
}
