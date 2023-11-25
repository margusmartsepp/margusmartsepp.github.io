# Hierarchical Analysis (HA) Function Overview

## Description
The HA function is designed to systematically analyze and break down complex topics into structured layers. It's akin to peeling an onion, layer by layer, to explore a topic's various aspects in an organized manner. This process aids in comprehensively understanding a subject by examining its different facets.

## How It Works
- You provide a **topic** and a **depth** for analysis.
- The HA function processes this information, potentially using advanced language models, to create a structured outline.
- The result is a breakdown from general information to specific details, enhancing understanding of complex subjects.

## Example Use Cases
1. **HA "Climate Change" 3** - From a general overview to specific impacts on ecosystems.
2. **HA "Solar System" 4** - Analysis from the solar system overview to the molecular structure of planets.
3. **HA "Artificial Intelligence" 2** - Basic concepts to applications like machine learning.
4. **HA "Renaissance Art" 3** - Historical perspective to specific famous artworks.
5. **HA "Quantum Computing" 4** - Fundamentals to challenges and future prospects.
6. **HA "Global Cuisine" 2** - Overview of regional cuisines to signature dishes.

## Additional Feature: Paging
- **Paging**: Organizes information into "pages," each containing a portion of the analysis.
- **Page Selection**: Option to specify a starting page, similar to selecting a chapter in a book.
- **Default Page**: If not specified, the analysis starts from the first page.

### Paging Example
- **HA "Genetics" 3, Page 2** - Analyze genetics to a depth of three layers, starting directly from the second page of the analysis.

```c#
/// <summary>
/// Base class for data transfer objects.
/// PropertyChanged.Fody is used to automatically implement property change notification.
/// </summary>
public class BaseDto : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
}

public class HierarchicalAnalysisRequest : BaseDto
{
    public string Topic { get; set; }
    public int Depth { get; set; }
}

public class HierarchicalAnalysisResponse : BaseDto
{
    public List<string> Content { get; set; }
    public int PageCurrent { get; set; }
    public int PageMax { get; set; }
}

public interface ILLMQueryService
{
    /// <summary>
    /// Processes a hierarchical analysis request using a Large Language Model (LLM).
    /// The first line of the response should be formatted as:
    /// "Hierarchical analysis for '{topic}', page [{PageCurrent}/{PageMax}], depth {Depth}"
    /// 
    /// Long Version:
    /// "LLM Post(new HierarchicalAnalysisRequest {Topic = 'topic', Depth = depth})"
    /// This represents processing a HierarchicalAnalysisRequest with the LLM service.
    ///
    /// Alias Shorthand:
    /// "HA 'topic' depth"
    /// This shorthand will be interpreted as the long version above.
    /// </summary>
    /// <param name="request">HierarchicalAnalysisRequest containing the topic and depth for analysis.</param>
    /// <returns>HierarchicalAnalysisResponse containing the generated content, current page, and max page.</returns>
    /// <remarks>
    /// Example use case:
    /// <code>
    /// var haService = [Some implementation of ILLMQueryService];
    /// var haResponse = haService.Post(new HierarchicalAnalysisRequest { Topic = "Water States", Depth = 4 });
    /// foreach (var line in haResponse.Content)
    /// {
    ///     Console.WriteLine(line);
    /// }
    /// </code>
    /// This method interacts with an LLM service to process the request and generate a hierarchical structure.
    /// </remarks>
    HierarchicalAnalysisResponse Post(HierarchicalAnalysisRequest request);
}

// Usage in a context that consumes ILLMQueryService is illustrated in the example above.

```