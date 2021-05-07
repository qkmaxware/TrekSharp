using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TrekSharp.Generators {

/// <summary>
/// Generic generator that performs repeated insertions into a string based on a DSL
/// use '@name' or '@name(s)' for repeated insertion and \<\a\> for insertion of 'a' or 'an' depending on the context 
/// </summary>
public class StringGenerator {

    public Dictionary<string, List<string>> Phrases {get; private set;}

    private static Regex replacement = new Regex(@"\@[\w-]+(?:\(s\))?");
    private static Regex an = new Regex(@"\<an?\>(\s*\w)?");

    public StringGenerator() : this(new Dictionary<string, List<string>>()) {}
    public StringGenerator(Dictionary<string, List<string>> phrases) {
        this.Phrases = phrases;
    }

    private static string pluralize(string value) {
        if (value.Length < 1)
            return value;

        var last_letter = value[value.Length - 1];
        switch (last_letter) {
            case 's':
            case 'h':
            case 'x':
            case 'z':
                return value + "es";
            default:
                return value + "s";
        }
    }

    public string Generate(List<string> templates) {
        // 1. Pick template
        return Generate(templates.Random());
    }

    public string Generate(string template) {
        // Generate
        // 2. While subcomponents exist, substitute
        
        while (replacement.IsMatch(template)) {
            template = replacement.Replace(template, (match) => {
                var property = match.Value.Substring(1); // without the @
                var plural = false;
                if (property.EndsWith("(s)")) {
                    plural = true;
                    property = property.Substring(0, property.Length - 3);
                }

                if (Phrases.ContainsKey(property)) {
                    var thing = Phrases[property].Random();
                    if (plural) {
                        thing = pluralize(thing);
                    }
                    return thing;
                } else {
                    return string.Empty;
                }
            });
        }

        // 3. Cleanup a/an
        template = an.Replace(template, (match) => {
            // Get next letter
            var next_letter = match.Groups[1]?.Value?.Trim();
            if (next_letter == null)
                return string.Empty; // no next character, delete this <an>
                
            // Determine if 'a' or 'an' should be used
            var letter = next_letter.ToLower();
			switch (letter) {
				case "a":
				case "e":
				case "i":
				case "o":
				case "u":
					return "an" + match.Groups[1].Value; // is a vowel
				default: 
					return "a"  + match.Groups[1].Value; // is a consonant
			};
        });

        // 4. Capitalize first letter
        template = char.ToUpper(template[0]).ToString() + template.Substring(1);

        return template;
    }

}

}