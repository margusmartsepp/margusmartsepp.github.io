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
