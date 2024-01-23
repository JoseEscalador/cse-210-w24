
public class PromptGenerator {
    public List<String> _prompts;
    
    public string GetRandomPrompt(){
        Random randomGenerator = new Random();
        return _prompts[randomGenerator.Next(0, _prompts.Count())];
    } 
}