# IdeaFlow Language Specification v0.0.1

## Overview
IdeaFlow v0.0.1 is a user-centric instruction language designed for processing, evaluating, and selecting ideas in decision-making contexts. It enhances user input comprehension using CLARITYs, MASCO, and ZIP features.

## Language Structure
- **Natural Language Commands**: Allows expression in everyday language.
- **Multimodal Inputs**: Supports text, voice, and potential visual inputs.
- **LLM Integration**: Technical details are managed by the LLM for seamless user experience.

## Example Scenarios

### Finding a Book for a Child
- **User Input**: "Find a book for a 9-year-old in Siili Raamatukogu who knows Estonian, Russian, and basic English."
- **LLM Interpretation & Execution**: System uses commands like `FilterIdeas`, `EvaluateIdeaQuality`, and `LocateRelevantIdeas`.
- **Response Generation**: Provides book recommendations with summaries and availability.

IdeaFlow is designed to keep users in their flow, reducing technical complexities and enabling intuitive interactions with the LLM.

# IdeaFlow Language Specification v0.0.2

## Overview
IdeaFlow v0.0.2 integrates an Auditor module to enhance accuracy and relevance in processing and generating responses to user inputs.

## Auditor Module (v1.0.1)
- **Function**: Reviews user inputs and system outputs.
- **Responsibilities**:
  - Assess and review for precision and accuracy.
  - Suggest improvements to IdeaFlow and its own instructions.
  - Maintain version and instruction awareness.
- **User Accessibility**: View full IdeaFlow spec and Auditor assessments.

## Assessment Metrics
- **Precision**: Measures input/output specificity.
- **Accuracy**: Evaluates factual correctness and relevancy.
- **Potential for Alternative Outcomes**: Considers other possibilities or interpretations.

## Workflow
1. **User Input**: Receive and process queries.
2. **Input Assessment**: Auditor evaluates for precision, accuracy.
3. **LLM Execution**: Processes input, executes commands.
4. **Output Generation**: Formulates response.
5. **Output Assessment**: Auditor reviews for accuracy, relevance.
6. **User Interaction**: Presents response and Auditor feedback.

IdeaFlow v0.0.2, powered by the Auditor, ensures adaptability, accuracy, and user-responsiveness.
# IdeaFlow Language Specification v0.0.3

## Alias Definitions
- **IFA**: Refers to IdeaFlow and its integrated Auditor module.
- **diff**: Represents the changes or differences between one version of IdeaFlow and the next.

## Overview
IdeaFlow v0.0.3 is an enhanced user-centric instruction language designed for processing, evaluating, and selecting ideas with a focus on precision, detail, and user preference.

## Language Structure
- **Token Allocation**: Up to 800 tokens for request assessment, 800 for response assessment, and over 2400 for response content.
- **Response Detail and Nuance**: Enhanced emphasis on detailed, nuanced responses.
- **Customized Formatting**: Standardized format for response delivery.
- **User Preference Application**: Feature to track and apply individual user preferences.
- **Narrative Style Responses**: Implementation of engaging narrative styles in responses.
- **Continuous Learning**: System adapts based on user feedback and evolving preferences.

## Auditor Module (v1.0.2)
- **Enhanced Review Capabilities**: Auditor now assesses responses for depth, nuance, and alignment with user preferences.
- **Narrative Style Assessment**: Evaluates the effectiveness of narrative-style responses.

## Changes (diff) from v0.0.2 to v0.0.3
1. Increased token allocation for more detailed responses.
2. Focus on creating more nuanced responses.
3. Standardization of response formatting.
4. Incorporation of user preference tracking and application.
5. Implementation of narrative style in responses.
6. Strengthening continuous learning capabilities.

## Workflow
1. User Input: Receive and process queries.
2. Input Assessment: Auditor evaluates for precision, accuracy, and user preference alignment.
3. LLM Execution: Processes input, executes commands.
4. Output Generation: Formulates detailed, nuanced, and narrative-style response.
5. Output Assessment: Auditor reviews for depth, narrative style effectiveness, and user preference alignment.
6. User Interaction: Presents response and Auditor feedback, tailored to user preferences.


# IdeaFlow Language Specification v0.0.4

## Overview
IdeaFlow v0.0.4 continues to refine the user-centric instruction language, emphasizing adaptability and enhanced user interaction.

## New Features in v0.0.4
- **Dynamic Command Creation**: Users, Auditors, and the LLM can create new commands as needed.
- **Command Repository**: A repository for newly created commands, allowing for continuous expansion.

## Known Commands
Certainly, here are the full definitions for all commands in IdeaFlow v0.0.4 with parent items:

### AggregateIdeaData
- **Parents**: #EvaluateAndIdentify
- **Functionality**: Aggregates data related to ideas for summary and analysis.
- **Request Parameters**: Data set of ideas.
- **Response**: Aggregated data summary.

### AnalyzeConflictingIdeas
- **Parents**: #EvaluateAndIdentify
- **Functionality**: Analyzes and highlights differences and conflicts between various ideas.
- **Request Parameters**: Set of ideas for analysis.
- **Response**: Analysis report outlining conflicts.

### EvaluateIdeaQuality
- **Parents**: #EvaluateAndIdentify
- **Functionality**: Assesses the overall quality of ideas based on established criteria.
- **Request Parameters**: Ideas to be evaluated, evaluation criteria.
- **Response**: Quality assessment results.

### EvaluateSourceReliability
- **Parents**: #EvaluateAndIdentify
- **Functionality**: Determines the reliability and credibility of different idea sources.
- **Request Parameters**: Sources to be evaluated.
- **Response**: Reliability ratings for each source.

### IdentifyIdeaRisks
- **Parents**: #EvaluateAndIdentify
- **Functionality**: Identifies potential risks or downsides associated with specific ideas.
- **Request Parameters**: Ideas for risk assessment.
- **Response**: Risk profile for each idea.

### FilterIdeas
- **Parents**: #FilterAndSort
- **Functionality**: Filters ideas based on predicates in various operational contexts.
- **Request Parameters**: Predicates, Data Source.
- **Response**: Filtered list of ideas.

### SortIdeas
- **Parents**: #FilterAndSort
- **Functionality**: Sorts a collection of ideas based on specified attributes.
- **Request Parameters**: Ideas to be sorted, sorting attributes.
- **Response**: Sorted list of ideas.

### GenerateIdeaSummary
- **Parents**: #GenerateAndPredict
- **Functionality**: Creates summarized overviews of selected ideas.
- **Request Parameters**: Ideas to summarize.
- **Response**: Concise summaries of ideas.

### PredictIdeaEvolution
- **Parents**: #GenerateAndPredict
- **Functionality**: Forecasts potential changes or developments in ideas over time.
- **Request Parameters**: Ideas for prediction, time frame.
- **Response**: Predictions on idea evolution.

### RecommendStrategicApproach
- **Parents**: #RecommendAndSelect
- **Functionality**: Suggests strategic approaches based on comprehensive analysis.
- **Request Parameters**: Context for strategy recommendation.
- **Response**: Recommended strategies.

### SelectOptimalIdea
- **Parents**: #RecommendAndSelect
- **Functionality**: Chooses the most appropriate idea based on specific criteria.
- **Request Parameters**: Set of ideas, selection criteria.
- **Response**: The selected optimal idea.

### AssessRiskLevels
- **Parents**: #RiskManagement
- **Functionality**: Evaluates the levels of risk associated with different ideas.
- **Request Parameters**: Ideas for risk level assessment.
- **Response**: Risk level assessment for each idea.

### CalculateRiskRewardBalance
- **Parents**: #RiskManagement
- **Functionality**: Analyzes the balance between potential risks and rewards of pursuing specific ideas.
- **Request Parameters**: Ideas for risk-reward analysis.
- **Response**: Risk-reward balance analysis.

### SetIdeaProximityPreference
- **Parents**: #SetAndCompare
- **Functionality**: Sets preferences for idea sourcing based on proximity.
- **Request Parameters**: Proximity preferences.
- **Response**: Adjusted preferences for idea sourcing.

### CompareIdeaAlignment
- **Parents**: #SetAndCompare
- **Functionality**: Measures the alignment of ideas with specific decision criteria.
- **Request Parameters**: Ideas, criteria for alignment.
- **Response**: Alignment scores.

### LocateRelevantIdeas
- **Parents**: #SetAndCompare
- **Functionality**: Identifies ideas that are relevant to specific criteria or contexts.
- **Request Parameters**: Criteria for relevance.
- **Response**: List of relevant ideas.

## Workflow Enhancement
- **User Input Processing**: Improved handling of diverse inputs.
- **Command Integration**: Seamless integration of newly created commands into the workflow.
- **Enhanced Auditor Feedback**: More detailed feedback from the Auditor, including suggestions for new commands.

## Auditor Module (v1.0.3)
- **Dynamic Command Assessment**: Reviews and integrates newly created commands.
- **Feedback Loop**: Incorporates user and system feedback for continuous improvement.

## Changes (diff) from v0.0.3 to v0.0.4
1. Introduction of dynamic command creation.
2. Establishment of a command repository.
3. Workflow enhancements for better integration of new commands.
4. Auditor module updates for dynamic command assessment.

## Future Directions
- Focus on expanding the command set and refining user interaction based on evolving needs and feedback.

IdeaFlow v0.0.4 represents a step forward in making the language more adaptable and responsive to user needs and system evolution.
