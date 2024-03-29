using System.Collections.Generic;
using System.Linq;

namespace TrekSharp.Generators {

public class ValueGenerator {
    private Dictionary<Disciplines, List<string>> values = new Dictionary<Disciplines, List<string>>{
        {new Disciplines { Command = 1 }, new List<string>{
            "Doesn’t Believe in a No-Win Situation",
            "Risk is Our Business",
            "Seek Out New Life, and New Civilizations",
            "Compassion through Understanding",
            "The Drive for Exploration",
            "The Needs of the Many Outweigh the Needs of the Few, or the One",
            "A Starship is a Home, it’s Crew a Family",
            "Most Comfortable in a Crowd",
            "Serving Starfleet is a Family Tradition",
            "Indefatigable Confidence",
            "Proud and Honest",
            "A Responsibility to the Truth",
            "Inexperienced and Idealistic",
            "Fast Ships and Strange New Worlds",
            "Exploring to Test New Theories",
            "Seen Too Much to be Surprised",
            "Holds Everyone to the Highest Standards",
            "We Endure Hardship, So That Others Do Not Have To",
            "A Failure to Act Can Be As Dangerous As Acting Rashly",
        }},
        {new Disciplines { Security = 1 }, new List<string>{
            "Risk is Our Business",
            "Safety in Numbers",
            "The Needs of the Many Outweigh the Needs of the Few, or the One",
            "A Starship is a Home, it’s Crew a Family",
            "Most Comfortable in a Crowd",
            "Body and Mind Alike Must Be Healthy",
            "No Stranger to Violence",
            "Emotion in a Crisis only Makes Things Worse",
            "Serving Starfleet is a Family Tradition",
            "Indefatigable Confidence",
            "Inexperienced and Idealistic",
            "Always Prepared, Always Vigilant",
            "Seen Too Much to be Surprised",
            "The Price of Peace is Vigilance",
            "Living with Your Ideals is Harder than Dying for Them",
            "There Is No Higher Calling Than to Serve",
            "We Endure Hardship, So That Others Do Not Have To",
            "A Failure to Act Can Be As Dangerous As Acting Rashly",
        }},
        {new Disciplines { Science = 1 }, new List<string>{
            "There’s No Such Thing as The Unknown — Only the Temporarily Hidden",
            "Logic is the Beginning, not the end, of Wisdom",
            "Seek Out New Life, and New Civilizations",
            "Compassion through Understanding",
            "The Drive for Exploration",
            "All Ideas must Withstand Scrutiny",
            "A Starship is a Home, it’s Crew a Family",
            "Most Comfortable in a Crowd",
            "Engineer at Heart",
            "Serving Starfleet is a Family Tradition",
            "Indefatigable Confidence",
            "Proud and Honest",
            "Insatiable Curiosity",
            "Understands Technology Better Than People",
            "A Responsibility to the Truth",
            "Inexperienced and Idealistic",
            "Precise to a Fault",
            "Exploring to Test New Theories",
            "A Theory For Every Situation",
            "Seen Too Much to be Surprised",
            "Nothing Better Than Practical Experience",
        }},
        {new Disciplines { Conn = 1 }, new List<string>{
            "Compassion through Understanding",
            "A Starship is a Home, it’s Crew a Family",
            "Most Comfortable in a Crowd",
            "Serving Starfleet is a Family Tradition",
            "Indefatigable Confidence",
            "Proud and Honest",
            "Inexperienced and Idealistic",
            "Always Prepared, Always Vigilant",
            "Fast Ships and Strange New Worlds",
            "Seen Too Much to be Surprised",
        }},
        {new Disciplines { Engineering = 1 }, new List<string>{
            "Risk is Our Business",
            "Logic is the Beginning, not the end, of Wisdom",
            "Compassion through Understanding",
            "All Ideas must Withstand Scrutiny",
            "A Starship is a Home, it’s Crew a Family",
            "Most Comfortable in a Crowd",
            "Serving Starfleet is a Family Tradition",
            "Indefatigable Confidence",
            "Proud and Honest",
            "Insatiable Curiosity",
            "Understands Technology Better Than People",
            "Inexperienced and Idealistic",
            "Threw Out The Handbook and Wrote My Own",
            "Precise to a Fault",
            "A Theory For Every Situation",
            "Seen Too Much to be Surprised",
            "Nothing Better Than Practical Experience",
        }},
        {new Disciplines { Medicine = 1 }, new List<string>{
            "Compassion through Understanding",
            "All Ideas must Withstand Scrutiny",
            "The Needs of the Many Outweigh the Needs of the Few, or the One",
            "A Starship is a Home, it’s Crew a Family",
            "Most Comfortable in a Crowd",
            "Body and Mind Alike Must Be Healthy",
            "Serving Starfleet is a Family Tradition",
            "Indefatigable Confidence",
            "Proud and Honest",
            "Insatiable Curiosity",
            "A Responsibility to the Truth",
            "Inexperienced and Idealistic",
            "Threw Out The Handbook and Wrote My Own",
            "Precise to a Fault",
            "Seen Too Much to be Surprised",
            "Driven to Ease Suffering",
            "Rough and Tumble Doctor",
        }},
    };

    public string GenerateValueForDiscipline(Disciplines mask) {
        var lists = this.values.Where(kv => kv.Key.SharesDisciplinesWith(mask)).Select(kv => kv.Value).ToList();
        var list = lists.Random();
        var element = list.Random();
        return element;
    }
}

}