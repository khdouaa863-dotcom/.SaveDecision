using System;

namespace JuryFormationSystem
{
    public enum Recommendation
    {
        Accept,
        Revision,
        Reject
    }

    public class CommitteeDecision
    {
        public int DecisionId { get; set; }
        public int MeetingId { get; set; }
        public Recommendation DecisionType { get; set; }
        public string DecisionText { get; set; }
        public DateTime DecisionDate { get; set; }
        public string File { get; set; }

        public CommitteeDecision(int decisionId, int meetingId, Recommendation decisionType, string decisionText, string file)
        {
            DecisionId = decisionId;
            MeetingId = meetingId;
            DecisionType = decisionType;
            DecisionText = decisionText;
            DecisionDate = DateTime.Now;
            File = file;
        }

        public bool SaveDecision()
        {
            try
            {
                Console.WriteLine($"[SUCCESS] Decision ID {DecisionId} has been saved successfully.");
                Console.WriteLine($"Details: Type={DecisionType}, Date={DecisionDate.ToShortDateString()}, File={File}");
                return true; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Failed to save decision: {ex.Message}");
                return false;
            }
        }
    }
}