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
