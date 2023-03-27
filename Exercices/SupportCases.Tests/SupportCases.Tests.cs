using System;
using Xunit;

namespace SupportCases.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Quick3Sort_InputListWithOnlyTicket_ShouldReturnSameList()
        {
            SupportTicket[] tickets = {
            new SupportTicket(1, "Everything is broken", PriorityLevel.Critical)
            };
            SupportTicket[] sortedTickets = {
            new SupportTicket(1, "Everything is broken", PriorityLevel.Critical)
            };
            Program.Quick3Sort(tickets);
            Assert.Equal(tickets, sortedTickets);
        }


        [Fact]
        public void Quick3Sort_InputShortListWithAllPriorityLeveles_ShouldReturnSortedList()
        {
            SupportTicket[] tickets = {
            new SupportTicket(1, "Lost dog", PriorityLevel.Medium),
            new SupportTicket(2, "Sun is turning green", PriorityLevel.Critical),
            new SupportTicket(3, "WW3", PriorityLevel.Important),
            new SupportTicket(4, "Spilled coffe on my new shirt", PriorityLevel.Low)
            };
            SupportTicket[] sortedTickets = {
            new SupportTicket(2, "Sun is turning green", PriorityLevel.Critical),
            new SupportTicket(3, "WW3", PriorityLevel.Important),
            new SupportTicket(1, "Lost dog", PriorityLevel.Medium),
            new SupportTicket(4, "Spilled coffe on my new shirt", PriorityLevel.Low),
            };
            Program.Quick3Sort(tickets);
            Assert.Equal(tickets, sortedTickets);
        }

        [Fact]
        public void Quick3Sort_InputListWithSimilarPriorityLevel_ShouldReturnSortedListList()
        {
            SupportTicket[] tickets = {
            new SupportTicket(1, "Lost dog", PriorityLevel.Medium),
            new SupportTicket(2, "Sun is turning green", PriorityLevel.Critical),
            new SupportTicket(3, "WW3", PriorityLevel.Important),
            new SupportTicket(4, "Spilled coffe on my new shirt", PriorityLevel.Low),
            new SupportTicket(5, "Black Hole", PriorityLevel.Critical),
            new SupportTicket(6, "Get Food Poisoning", PriorityLevel.Low),
            new SupportTicket(7, "Black Plague", PriorityLevel.Important),
            new SupportTicket(8, "No presents for Chirstmas", PriorityLevel.Low),
            new SupportTicket(9, "Lost car", PriorityLevel.Medium),
            new SupportTicket(10, "Guta Retireds", PriorityLevel.Critical),
            new SupportTicket(11, "Police Emergency", PriorityLevel.Medium),
            new SupportTicket(12, "Game Over in Mario", PriorityLevel.Low)
            };
            SupportTicket[] sortedTickets = {
            new SupportTicket(2, "Sun is turning green", PriorityLevel.Critical),
            new SupportTicket(10, "Guta Retireds", PriorityLevel.Critical),
            new SupportTicket(5, "Black Hole", PriorityLevel.Critical),
            new SupportTicket(3, "WW3", PriorityLevel.Important),
            new SupportTicket(7, "Black Plague", PriorityLevel.Important),
            new SupportTicket(9, "Lost car", PriorityLevel.Medium),
            new SupportTicket(1, "Lost dog", PriorityLevel.Medium),
            new SupportTicket(11, "Police Emergency", PriorityLevel.Medium),
            new SupportTicket(6, "Get Food Poisoning", PriorityLevel.Low),
            new SupportTicket(4, "Spilled coffe on my new shirt", PriorityLevel.Low),
            new SupportTicket(8, "No presents for Chirstmas", PriorityLevel.Low),
            new SupportTicket(12, "Game Over in Mario", PriorityLevel.Low)
            };
            Program.Quick3Sort(tickets);
            Assert.Equal(tickets, sortedTickets);
        }
    }
}
