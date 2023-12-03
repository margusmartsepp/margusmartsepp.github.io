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

# IdeaFlow Language Specification v0.0.5

## Overview
IdeaFlow v0.0.5 commands were converted into JSON format. Each command will be structured with its name, description, parameters, and expected response. 

## Known Commands

1. **AggregateIdeaData**
   ```json linenums="1"
   {
     "name": "AggregateIdeaData",
     "description": "Aggregates data related to ideas for summary and analysis.",
     "parameters": {
       "type": "object",
       "properties": {
         "DataSetOfIdeas": {
           "type": "array",
           "description": "Data set of ideas."
         }
       },
       "required": ["DataSetOfIdeas"]
     }
   }
   ```

2. **AnalyzeConflictingIdeas**
   ```json
   {
     "name": "AnalyzeConflictingIdeas",
     "description": "Analyzes and highlights differences and conflicts between various ideas.",
     "parameters": {
       "type": "object",
       "properties": {
         "SetOfIdeas": {
           "type": "array",
           "description": "Set of ideas for analysis."
         }
       },
       "required": ["SetOfIdeas"]
     }
   }
   ```

3. **EvaluateIdeaQuality**
   ```json
   {
     "name": "EvaluateIdeaQuality",
     "description": "Assesses the overall quality of ideas based on established criteria.",
     "parameters": {
       "type": "object",
       "properties": {
         "IdeasToBeEvaluated": {
           "type": "array",
           "description": "Ideas to be evaluated."
         },
         "EvaluationCriteria": {
           "type": "object",
           "description": "Evaluation criteria."
         }
       },
       "required": ["IdeasToBeEvaluated", "EvaluationCriteria"]
     }
   }
   ```

4. **EvaluateSourceReliability**
   ```json
   {
     "name": "EvaluateSourceReliability",
     "description": "Determines the reliability and credibility of different idea sources.",
     "parameters": {
       "type": "object",
       "properties": {
         "SourcesToBeEvaluated": {
           "type": "array",
           "description": "Sources to be evaluated."
         }
       },
       "required": ["SourcesToBeEvaluated"]
     }
   }
   ```

5. **IdentifyIdeaRisks**
   ```json
   {
     "name": "IdentifyIdeaRisks",
     "description": "Identifies potential risks or downsides associated with specific ideas.",
     "parameters": {
       "type": "object",
       "properties": {
         "IdeasForRiskAssessment": {
           "type": "array",
           "description": "Ideas for risk assessment."
         }
       },
       "required": ["IdeasForRiskAssessment"]
     }
   }
   ```
   
6. **FilterIdeas**
   ```json
   {
     "name": "FilterIdeas",
     "description": "Filters ideas based on predicates in various operational contexts.",
     "parameters": {
       "type": "object",
       "properties": {
         "Predicates": {
           "type": "object",
           "description": "Predicates for filtering."
         },
         "DataSource": {
           "type": "array",
           "description": "Data Source containing ideas."
         }
       },
       "required": ["Predicates", "DataSource"]
     }
   }
   ```

7. **SortIdeas**
   ```json
   {
     "name": "SortIdeas",
     "description": "Sorts a collection of ideas based on specified attributes.",
     "parameters": {
       "type": "object",
       "properties": {
         "IdeasToBeSorted": {
           "type": "array",
           "description": "Ideas to be sorted."
         },
         "SortingAttributes": {
           "type": "object",
           "description": "Sorting attributes."
         }
       },
       "required": ["IdeasToBeSorted", "SortingAttributes"]
     }
   }
   ```

8. **GenerateIdeaSummary**
   ```json
   {
     "name": "GenerateIdeaSummary",
     "description": "Creates summarized overviews of selected ideas.",
     "parameters": {
       "type": "object",
       "properties": {
         "IdeasToSummarize": {
           "type": "array",
           "description": "Ideas to summarize."
         }
       },
       "required": ["IdeasToSummarize"]
     }
   }
   ```

9. **PredictIdeaEvolution**
   ```json
   {
     "name": "PredictIdeaEvolution",
     "description": "Forecasts potential changes or developments in ideas over time.",
     "parameters": {
       "type": "object",
       "properties": {
         "IdeasForPrediction": {
           "type": "array",
           "description": "Ideas for prediction."
         },
         "TimeFrame": {
           "type": "string",
           "description": "Time frame for prediction."
         }
       },
       "required": ["IdeasForPrediction", "TimeFrame"]
     }
   }
   ```

10. **RecommendStrategicApproach**
    ```json
    {
      "name": "RecommendStrategicApproach",
      "description": "Suggests strategic approaches based on comprehensive analysis.",
      "parameters": {
        "type": "object",
        "properties": {
          "ContextForStrategyRecommendation": {
            "type": "object",
            "description": "Context for strategy recommendation."
          }
        },
        "required": ["ContextForStrategyRecommendation"]
      }
    }
    ```

11. **SelectOptimalIdea**
    ```json
    {
      "name": "SelectOptimalIdea",
      "description": "Chooses the most appropriate idea based on specific criteria.",
      "parameters": {
        "type": "object",
        "properties": {
          "SetOfIdeas": {
            "type": "array",
            "description": "Set of ideas."
          },
          "SelectionCriteria": {
            "type": "object",
            "description": "Selection criteria."
          }
        },
        "required": ["SetOfIdeas", "SelectionCriteria"]
      }
    }
    ```

12. **AssessRiskLevels**
    ```json
    {
      "name": "AssessRiskLevels",
      "description": "Evaluates the levels of risk associated with different ideas.",
      "parameters": {
        "type": "object",
        "properties": {
          "IdeasForRiskLevelAssessment": {
            "type": "array",
            "description": "Ideas for risk level assessment."
          }
        },
        "required": ["IdeasForRiskLevelAssessment"]
      }
    }
    ```

13. **CalculateRiskRewardBalance**
    ```json
    {
      "name": "CalculateRiskRewardBalance",
      "description": "Analyzes the balance between potential risks and rewards of pursuing specific ideas.",
      "parameters": {
        "type": "object",
        "properties": {
          "IdeasForRiskRewardAnalysis": {
            "type": "array",
            "description": "Ideas for risk-reward analysis."
          }
        },
        "required": ["IdeasForRiskRewardAnalysis"]
      }
    }
    ```

14. **SetIdeaProximityPreference**
    ```json
    {
      "name": "SetIdeaProximityPreference",
      "description": "Sets preferences for idea sourcing based on proximity.",
      "parameters": {
        "type": "object",
        "properties": {
          "ProximityPreferences": {
            "type": "object",
            "description": "Proximity preferences."
          }
        },
        "required": ["ProximityPreferences"]
      }
    }
    ```

15. **CompareIdeaAlignment**
    ```json
    {
      "name": "CompareIdeaAlignment",
      "description": "Measures the alignment of ideas with specific decision criteria.",
      "parameters": {
        "type": "object",
        "properties": {
          "Ideas": {
            "type": "array",
            "description": "Ideas to compare."
          },
          "CriteriaForAlignment": {
            "type": "object",
            "description": "Criteria for alignment."
          }
        },
        "required": ["Ideas", "CriteriaForAlignment"]
      }
    }
    ```

16. **LocateRelevantIdeas**
    ```json
    {
      "name": "LocateRelevantIdeas",
      "description": "Identifies ideas that are relevant to specific criteria or contexts.",
      "parameters": {
        "type": "object",
        "properties": {
          "CriteriaForRelevance": {
            "type": "object",
            "description": "Criteria for relevance."
          }
        },
        "required": ["CriteriaForRelevance"]
      }
    }
    ```
# IdeaFlow Language Specification v0.0.6

**Introduction:**
IdeaFlow v0.0.6 represents an evolution in the language used for structuring and managing workflows within a product development context. This version focuses on refining the language for clarity, precision, and efficiency, ensuring that even non-technical stakeholders can understand the workflow processes.

**Key Learnings and Advancements:**

1. **Enhanced Readability:**
   - Inline Comments: The use of inline comments following function calls has been emphasized for better readability and understanding. These comments explain the purpose of each function succinctly, allowing users who may not be familiar with code to grasp the workflow easily.

2. **Efficient Error Handling:**
   - Structured Error Handling: Improved error handling mechanisms with explanatory inline comments have been implemented. This makes the workflow more robust and user-friendly, providing clear guidance in case of issues like incorrect data formats or unexpected runtime errors.

3. **Function Naming Conventions:**
   - Self-Explanatory Function Names: The emphasis on descriptive and intuitive function names has been maintained. This approach ensures that the function's purpose is clearly understood, reducing reliance on extensive documentation.

4. **Workflow Structure and Documentation:**
   - Comprehensive Docstrings: Detailed docstrings at the beginning of functions provide essential information about the function's purpose, inputs, outputs, and potential error scenarios. This serves as an integral part of the documentation, enhancing user understanding.

5. **Adherence to Clean Code Principles:**
   - Avoidance of Redundant Comments and Empty Lines: Following clean coding practices, unnecessary comments and empty lines have been eliminated, streamlining the code for maintenance and scalability.

6. **Workflow Flexibility and Adaptability:**
   - Customizable Workflows: The workflow design accommodates different types of inputs and can be adapted to various product development contexts, demonstrating flexibility and scalability.

7. **Enhanced Troubleshooting Assistance:**
   - The workflow includes mechanisms for troubleshooting and handling unexpected scenarios, making it more reliable and user-friendly for all stakeholders.

8. **Integration of Feedback:**
   - The updated workflow incorporates stakeholder feedback more effectively, ensuring that the product development process remains aligned with evolving requirements and insights.

**Conclusion:**
IdeaFlow v0.0.6 represents a significant step towards making complex workflows more accessible, reliable, and efficient. By focusing on clarity, error handling, and adherence to clean coding principles, this version enhances the user experience for both technical and non-technical stakeholders in the product development process.

---

This specification provides an overview of the advancements and philosophies embedded in the IdeaFlow language as of version 0.0.6, highlighting its continued evolution towards efficiency, readability, and user-centric design.
### IdeaFlow Language Specification v0.0.6 - User Scenario with Alex

**User Scenario:**
- **User**: Alex, Product Manager at a tech company.
- **Challenge**: Alex is looking for a systematic method to develop a new software product that aligns with current market trends and company goals.
- **Input**: Alex queries, "InfoFlow: How can I systematically approach the development of a new software product, ensuring that all potential ideas are thoroughly evaluated and aligned with market trends and company goals?"

**Auditor Review and Plan Generation:**
- The Auditor reviews Alex's input to understand the requirements, accuracy, precision, etc.
- A plan is created in the form of pseudocode for `AFI_ProductDevelopmentWorkflow`, designed to address the specific needs outlined by Alex.
```python
def AFI_ProductDevelopmentWorkflow(market_data, company_goals, initial_ideas=None):
    """
    Executes a comprehensive workflow for product development from idea generation to final plan formulation.

    This function orchestrates the entire product development process, leveraging various AFI functions
    to process data, evaluate ideas, and formulate a strategic plan. It's designed to adapt to different inputs
    and provides structured error handling for troubleshooting.

    Args:
        market_data: Market data and trends relevant to product development.
        company_goals: Company's strategic goals and criteria for product development.
        initial_ideas (optional): An initial set of product ideas to start with.

    Returns:
        A detailed and strategically sound product development plan.

    Raises:
        ValueError: If inputs are not in the expected format or are missing critical information.
        RuntimeError: If an error occurs during the processing stages.
    """
    try:
        ideas = generateIdeaSummary(initial_ideas)  # Generating a wide range of initial product ideas.
        ideas = filterIdeas(ideas, market_data)  # Filtering ideas to retain only those relevant to the market.
        ideas = sortIdeasByFeasibility(ideas)  # Sorting ideas based on their feasibility and practicality.
        quality_assessment = evaluateIdeaQuality(ideas, company_goals)  # Evaluating the quality of each idea against the company's criteria.
        risk_profiles = identifyRisksInIdeas(ideas)  # Identifying potential risks associated with each idea.
        aggregated_data = aggregateDataForAnalysis(ideas, risk_profiles)  # Aggregating idea data for comprehensive analysis.
        market_analysis = analyzeMarketTrends(aggregated_data)  # Analyzing market trends to understand their impact on ideas.
        proximity_preferences = setMarketProximityPreferences(market_analysis)  # Setting proximity preferences based on market analysis.
        opportunities = locateMarketOpportunities(proximity_preferences)  # Locating market opportunities relevant to the generated ideas.
        source_reliability = evaluateMarketDataSources(opportunities)  # Evaluating the reliability of sources providing market data.
        idea_evolution = predictFutureOfIdeas(ideas, source_reliability)  # Predicting how the ideas might evolve in the future market context.
        risk_levels = assessRiskLevelsInIdeas(idea_evolution)  # Assessing the levels of risk associated with each idea.
        risk_reward_balance = calculateRiskRewardBalance(risk_levels)  # Calculating the balance between potential risks and rewards of each idea.
        optimal_idea = selectTheOptimalIdea(risk_reward_balance)  # Selecting the most promising idea based on risk-reward analysis.
        strategies = recommendStrategiesForIdeas(optimal_idea, company_goals)  # Recommending strategic approaches for the selected idea.
        alignment_scores = compareIdeaAlignmentWithGoals(strategies, company_goals)  # Comparing how well the ideas align with the company's long-term goals.
        idea_summaries = summarizeIdeasForStakeholders(alignment_scores)  # Summarizing the selected ideas for presentation to stakeholders.
        updated_workflow = updateWorkflowWithFeedback(idea_summaries)  # Updating the workflow based on stakeholder feedback.
        final_risk_assessment = assessFinalRiskLevels(updated_workflow)  # Conducting a final risk assessment of the chosen ideas.
        final_plan = finalizeProductDevelopmentPlan(final_risk_assessment)  # Finalizing the product development plan based on comprehensive analysis.

        return final_plan

    except ValueError as ve:
        handleValueError(ve)  # Handling errors related to incorrect data formats or missing information.
    except RuntimeError as re:
        handleRuntimeError(re)  # Handling runtime errors that may occur during the processing stages.
```
- Alex is asked to provide `market_data`, `company_goals`, and `initial_ideas`. Examples for each category are requested to ensure the workflow is tailored to the specific context of his project. Examples:
  1. **Market Data**: Trends in software technology, such as the rise of AI and cloud computing.
  2. **Company Goals**: Objectives such as leading innovation in AI technology or expanding market share in cloud-based solutions.
  3. **Initial Ideas**: Concepts like developing an AI-driven analytics tool or a cloud-based project management platform.
- Once Alex provides the necessary information, or if it's already available in the context, the Auditor reviews the output of the workflow.
- The workflow is processed with the given data to simulate a response.

**Simulated Response to Alex:**
- With the input provided, a detailed workflow is executed, and a response is simulated, showcasing how Alex's software product development can be methodically approached.

  **Simulated Outcome**:
  - A comprehensive plan is generated, focusing on key aspects such as market analysis, idea evaluation, risk assessment, and alignment with company goals.
  - The plan includes steps like idea generation and filtering, market trend analysis, feasibility studies, and strategic planning for product development and marketing.
  - A final product development strategy is outlined, which includes innovative approaches tailored to the latest market trends and company objectives.

**Conclusion:**
Through the IdeaFlow v0.0.6 framework, Alex receives a structured and actionable plan in the form of `AFI_ProductDevelopmentWorkflow`, enabling a systematic approach to software product development. The plan is designed to ensure thorough evaluation of ideas and their alignment with market trends and company goals, demonstrating the practical application of IdeaFlow in complex project planning scenarios.
