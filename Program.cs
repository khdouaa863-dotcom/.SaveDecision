using System;

namespace JuryFormationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Testing Jury Formation System - CommitteeDecision ===");
            Console.WriteLine();

            // بيانات تجريبية للاختبار
            int sampleDecisionId = 101;
            int sampleMeetingId = 505;
            Recommendation sampleType = Recommendation.Accept;
            string sampleText = "The student passed the thesis defense with minor revisions.";
            string sampleFile = "thesis_decision_101.pdf";

            // إنشاء الكائن
            CommitteeDecision decision = new CommitteeDecision(
                sampleDecisionId, 
                sampleMeetingId, 
                sampleType, 
                sampleText, 
                sampleFile
            );

            // استدعاء الدالة المراد اختبارها
            bool isSaved = decision.SaveDecision();

            if (isSaved)
            {
                Console.WriteLine("\n[TEST PASSED] The saveDecision() method executed perfectly.");
            }
            else
            {
                Console.WriteLine("\n[TEST FAILED] The saveDecision() method failed.");
            }
        }
    }
}