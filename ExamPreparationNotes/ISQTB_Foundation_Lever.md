The Sample Exam Q&A Set originates from [ISTQB Certified tester foundation level](https://www.istqb.org/certifications/certified-tester-foundation-level), and is here for searchability and quotations to allow faster learning. Visit their site for the most up-to-date version.

# Sample Exam set A | Version 1.7
(1 Point) Select ONE option.

1. Which one of the following answers describes a **test condition**?
    1. [ ] A distinguishing characteristic of a component or system
    1. [x] A testable aspect of a component or system identified as a basis for testing
    1. [ ] The degree to which a software product provides functions which meet stated and implied needs when the software is used under specified conditions
    1. [ ] Test cases designed to execute combinations of conditions and actions resulting from them
    
    > ### Explanation / Rationale
    > 1. Is not correct. Definition of **feature** according to glossary
    > 1. Is correct. From glossary
    > 1. Is not correct. Definition of functionality **suitability** according to glossary
    > 1. Is not correct. Like Definition of **Decision table testing** according to glossary

1. Which of the following statements is a valid objective for testing?
    1. [ ] The test should start as late as possible so that development had enough time to create a good product
    1. [x] To validate whether the test object works as expected by the users and other stakeholders
    1. [ ] To prove that all possible defects are identified
    1. [ ] To prove that any remaining defects will not cause any failures

    > ### Explanation / Rationale
    > 1. Is not correct. Contradiction to principle 3: “Early testing saves time and money”
    > 1. Is correct. This is one objective of testing
    > 1. Is not correct. Principle #2 states that exhaustive testing is impossible, so one can never prove that all defects were identified
    > 1. Is not correct. To make an assessment whether a defect will cause a failure or not, one must detect the defect first. Saying that no remaining defect will cause a failure implicitly means that all defects were found. This again contradicts principle #2

1. Which of the following statements correctly describes the difference between testing and
debugging?
    1. [ ] Testing identifies the source of defects; debugging analyzes the defects and proposes prevention activities
    1. [x] Dynamic testing shows failures caused by defects; debugging eliminates the defects, which are the source of failures
    1. [ ] Testing removes faults; but debugging removes defects that cause the faults
    1. [ ] Dynamic testing prevents the causes of failures; debugging removes the failures

    > ### Explanation / Rationale
    > 1. Is not correct. Testing does not identify the source of defects, debugging identifies the source of defects
    > 1. Is correct. Dynamic testing can show failures that are caused by defects in the software. Debugging eliminates the defects, which are the source of failures
    > 1. Is not correct. Testing does not remove faults, but debugging removes faults, which is synonyms for defects, that may cause the failures
    > 1. Is not correct. Dynamic testing does not directly prevent the causes of failures (defects) but detects the presence of defects

1. Which one of the statements below describes the most common situation for a failure discovered during testing or in production?
    1. [x] The product crashed when the user selected an option in a dialog box
    1. [ ] The wrong version of a compiled source code file was included in the build
    1. [ ] The computation algorithm used the wrong input variables
    1. [ ] The developer misinterpreted the requirement for the algorithm

    > ### Explanation / Rationale
    > 1. Is correct. A crash is clearly noticeable by the user
    > 1. Is not correct. This is a defect, not a failure since there is something wrong in the code. It may not result in a visible or noticeable failure, for example if the changes in the source code file are only in comments
    > 1. Is not correct. The use of wrong input variables may not result in a visible or noticeable failure, for example if nobody uses this particular algorithm; or if the wrong input variable has a similar value to the correct input variable; or if the FALSE result of the algorithm is not used
    > 1. Is not correct. This type of fault will not necessarily lead to a failure; for example, if no one uses this special algorithm

1. Mr. Test has been testing software applications on mobile devices for a period of 5 years. He has a wealth of experience in testing mobile applications and achieves better results in a shorter time than others. Over several months, Mr. Test did not modify the existing automated test cases and did not create any new test cases. This leads to fewer and fewer defects being found by executing the tests. What principle of testing did Mr. Test not observe?
    1. [ ] Testing depends on the environment
    1. [ ] Exhaustive testing is not possible
    1. [x] Repeating of same tests will not find new defects
    1. [ ] Defects cluster together

    > ### Explanation / Rationale
    > 1. Is not correct. Testing is context dependent, regardless of it being manual or automated (principle #6), but does not result in detecting a decreasing number of faults as described above
    > 1. Is not correct. Exhaustive testing is impossible, regardless of the amount of effort put into testing (principle #2)
    > 1. Is correct. Principle #5 says “If the same tests are repeated over and over again, eventually these tests no longer find any new defects. To detect new defects, existing tests and test data may need changing, and new tests may need to be written.” Automated regression testing of the same test cases will not bring new findings
    > 1. Is not correct. ”Defect cluster together” (principle #4). A small number of modules usually contain most of the defects, but this does not mean that fewer and fewer defects will be found

1. In what way can testing be part of Quality Assurance?
    1. [ ] It ensures that requirements are detailed enough
    1. [x] Testing reduces the risk of poor software quality
    1. [ ] It ensures that standards in the organization are followed
    1. [ ] It measures the quality of software in terms of number of executed test cases

    > ### Explanation / Rationale
    > 1. Is not correct. Static testing (reviews) contributes, but could not ensure, that requirements are detailed enough
    > 1. Is correct. Testing contributes to the achievement of quality in a variety of ways, e.g., such as reducing the risk of inadequate software quality
    > 1. Is not correct. This is quality assurance but not testing
    > 1. Is not correct. The quality cannot be measured by counting the number of executed test cases without knowing the outcome

1. Which of the following activities is part of the main activity "test analysis" in the test process?
    1. [ ] Identifying any required infrastructure and tools
    1. [ ] Creating test suites from test scripts
    1. [ ] Analyzing lessons learned for process improvement
    1. [x] Evaluating the test basis for testability

    > ### Explanation / Rationale
    > 1. Is not correct. This activity is performed during the test design activity (test design)
    > 1. Is not correct. This activity is performed during the test implementation activity (test implementation)
    > 1. Is not correct. This activity is performed during the test completion activity (test completion)
    > 1. Is correct. This activity is performed during the test analysis activity (test analysis)

1. Match the following test work products (1-4) with the right description (A-D).
    ```
    1. Test suite
    2. Test case
    3. Test script
    4. Test charter
    ----
    A. A set of test scripts to be executed in a specific test run
    B. A set of instructions for the execution of a test
    C. Contains expected results
    D. Documentation of test activities in session-based exploratory testing
    ```
    1. [x] 1A, 2C, 3B, 4D
    1. [ ] 1D, 2B, 3A, 4C
    1. [ ] 1A, 2C, 3D, 4B
    1. [ ] 1D, 2C, 3B, 4A

    > ### Explanation / Rationale
    > Glossary defines the following tests as:
    > * Test suite: “A set of test scripts or test procedures to be executed in a specific test run.” (1A)
    > * Test case: “A set of preconditions, inputs, actions (where applicable), expected results and post conditions, developed based on test conditions” (2C)
    > * Test script: “A sequence of instructions for the execution of a test” (3B)
    > * Test charter: “Documentation of test activities in session-based exploratory testing” (4D)

1. How can white-box testing be applied during user acceptance testing?
    1. [ ] To check if large volumes of data can be transferred between integrated systems
    1. [ ] To check if all code statements and code decision paths have been executed
    1. [x] To check if all work process flows have been covered
    1. [ ] To cover all web page navigations

    > ### Explanation / Rationale
    > 1. Is not correct. Relevant for integration testing
    > 1. Is not correct. Relevant for component testing
    > 1. Is correct. For acceptance testing, tests are designed to cover all workflows defined in the functional requirements documents.
    > 1. Is not correct. Relevant for system testing

1. Which of the following statements comparing component testing and system testing is TRUE?
    1. [ ] Component testing verifies the functionality of software modules, program objects, and classes that are separately testable, whereas system testing verifies interfaces between components and interactions between different parts of the system
    1. [x] Test cases for component testing are usually derived from component specifications, design specifications, or data models, whereas test cases for system testing are usually derived from requirement specifications or use cases
    1. [ ] Component testing only focuses on functional characteristics, whereas system testing focuses on functional and non-functional characteristics
    1. [ ] Component testing is the responsibility of the testers, whereas system testing typically is the responsibility of the users of the system

    > ### Explanation / Rationale
    > 1. Is not correct. System testing does not test interfaces between components and interactions between different parts of the system; this is a target of integration tests
    > 1. Is correct. Examples of work products that can be used as a test basis for component testing include detailed design, code, data model,component specifications. Examples of work products for system testing include system and software requirement specifications (functional and non-functional) use cases
    > 1. Is not correct. Component testing does not ONLY focus on functional characteristics
    > 1. Is not correct. Component tests are also executed by developers, whereas system testing typically is the responsibility of (independent)testers

1. Which one of the following is TRUE?
    1. [ ] The purpose of regression testing is to check if the correction has been successfully implemented, while the purpose of confirmation testing is to confirm that the correction has no side effects
    1. [ ] The purpose of regression testing is to detect unintended side effects, while the purpose of confirmation testing is to check if the system is still working in a new environment
    1. [x] The purpose of regression testing is to detect unintended side effects, while the purpose of confirmation testing is to check if the original defect has been fixed
    1. [ ] The purpose of regression testing is to check if the new functionality is working, while the purpose of confirmation testing is to check if the original defect has been fixed

    > ### Explanation / Rationale
    > 1. Is not correct. Regression testing does not check successful implementation of corrections and confirmation testing does not check for side effects
    > 1. Is not correct. The statement about confirmation testing should be about regression testing
    > 1. Is correct. See reasons from incorrect answers
    > 1. Is not correct. Testing new functionality is not regression testing

1. Which one of the following is the BEST definition of an incremental development model?
    1. [x] Defining requirements, designing software and testing are done in phases where in each phase a piece of the system is added
    1. [ ] A phase in the development process should begin when the previous phase is complete
    1. [ ] Testing is viewed as a separate phase which takes place after development has been completed
    1. [ ] Testing is added to development as an increment

    > ### Explanation / Rationale
    > 1. Is correct. Incremental development involves establishing requirements, designing, building, and testing a system in pieces
    > 1. Is not correct. This is a sequential model
    > 1. Is not correct. This describes the waterfall model
    > 1. Is not correct. Testing alone is not an increment/additional step in the development

1. Which of the following should NOT be a trigger for maintenance testing?
    1. [x] Decision to test the maintainability of the software
    1. [ ] Decision to test the system after migration to a new operating platform
    1. [ ] Decision to test if archived data is possible to be retrieved
    1. [ ] Decision to test after “hot fixes”

    > ### Explanation / Rationale
    > 1. Is correct. This is maintainability testing, not maintenance testing
    > 1. Is not correct. This is a trigger for maintenance testing: Operational tests of the new environment as well as of the changed software
    > 1. Is not correct. This is the trigger for maintenance testing: testing restore/retrieve procedures after archiving for long retention periods
    > 1. Is not correct. This is the trigger for maintenance testing: Reactive modification of a delivered software product to correct emergency defects that have caused actual failures

1. Which of the following options are roles in a formal review?
    1. [ ] Developer, Moderator, Review leader, Reviewer, Tester
    1. [ ] Author, Moderator, Manager, Reviewer, Developer
    1. [ ] Author, Manager, Review leader, Reviewer, Designer
    1. [x] Author, Moderator, Review leader, Reviewer, Scribe

    > ### Explanation / Rationale
    > 1. Is not correct. Tester and developer are NOT roles in a formal review
    > 1. Is not correct. Developer is NOT a role in a formal review
    > 1. Is not correct. Designer is NOT a role in a formal review
    > 1. Is correct. See reasons from incorrect answers

1. Which activities are carried out within the planning of a formal review?
    1. [ ] Collection of metrics for the evaluation of the effectiveness of the review
    1. [ ] Answer any questions the participants may have
    1. [x] Definition and Verification of fulfillment of entry criteria for the review
    1. [ ] Evaluation of the review findings against the exit criteria

    > ### Explanation / Rationale
    > 1. Is not correct. ‘Collection of metrics’ belongs to the main activity “Fixing and Reporting”
    > 1. Is not correct. ‘Answer any question.’ belongs to the main activity “Initiate Review”
    > 1. Is correct. The checking of entry criteria takes place in the planning of a formal review
    > 1. Is not correct. The evaluation of the review findings against the exit criteria belongs to the main activity “Issue communication and analysis”

1. Which of the review types below is the BEST option to choose when the review must follow a formal process based on rules and checklists?
    1. [ ] Informal Review
    1. [ ] Technical Review
    1. [x] Inspection
    1. [ ] Walkthrough

    > ### Explanation / Rationale
    > 1. Is not correct. Informal review does not use a formal process
    > 1. Is not correct. Use of checklists are optional
    > 1. Is correct. Inspection is a formal process based on rules and checklists
    > 1. Is not correct. Does not explicitly require a formal process and the use of checklists is optional

1. Which of the following statements about static testing are MOST true?
    1. [x] Static testing is a cheap way to detect and remove defects
    1. [ ] Static testing makes dynamic testing less challenging
    1. [ ] Static testing makes it possible to find run-time problems early in the lifecycle
    1. [ ] When testing safety-critical system, static testing has less value because dynamic testing finds the defects better

    > ### Explanation / Rationale
    > 1. Is correct. Defects found early are often much cheaper to remove than defects detected later in the lifecycle
    > 1. Is not correct. Dynamic testing still has its challenging because they find other types of defects
    > 1. Is not correct. This is dynamic testing
    > 1. Is not correct. Static testing is important for safety-critical computer systems

1. You will be invited to a review. The work product to be reviewed is a description of the in-house document creation process. The aim of the description is to present the work distribution between the different roles involved in the process in a way that can be clearly understood by everyone. You will be invited to a checklist-based review. The checklist will also be sent to you. It includes the following points:
    ```
    i. Is the person who performs the activity clearly identified for each activity?
    ii. Are the entry criteria clearly defined for each activity?
    iii. Are the exit criteria clearly defined for each activity?
    iv. Are the supporting roles and their scope of work clearly defined for each activity?
    ```
    In the following we show an excerpt of the work result to be reviewed, for which you should use the checklist above:

    "After checking the customer documentation for completeness and correctness, the software
    architect creates the system specification. Once the software architect has completed the system
    specification, he invites testers and verifiers to the review. A checklist describes the scope of the review. Each invited reviewer creates review comments - if necessary - and concludes the review with an official review done-comment."

    Which of the following statements about your review is correct?
    1. [ ] Point ii) of the checklist has been violated because it is not clear which condition must be fulfilled to invite to the review
    1. [ ] You notice that in addition to the tester and the verifier, the validator must also be invited. Since this item is not part of your checklist, you do not create a corresponding comment
    1. [ ] Point iii) of the checklist has been violated as it is not clear what marks the review as completed
    1. [x] Point i) of the checklist has been violated because it is not clear who is providing the checklist for the invitation to the review

    > ### Explanation / Rationale
    > 1. Is not correct. It is described that the software architect must have completed the system specification
    > 1. Is not correct. ‘Checklist-based’, last sentence it is documented that you should also look for defects outside the checklist
    > 1. Is not correct. It is described: every reviewer did his review done comment
    > 1. Is correct. It is described that a checklist is available, but who provides the checklist?

1. What is checklist-based testing?
    1. [ ] A test technique in which tests are derived based on the tester's knowledge of past faults, or general knowledge of failures
    1. [ ] A test technique based on an analysis of the specification of a component or system
    1. [x] An experience-based test technique whereby the experienced tester uses a list of items to be noted, checked, or remembered, or a set of rules or criteria against which a product must be verified
    1. [ ] An approach to testing where the testers dynamically design and execute tests based on their knowledge, exploration of the test item and the results of previous tests

    > ### Explanation / Rationale
    > 1. Is not correct. This is error guessing
    > 1. Is not correct. This is black-box test technique
    > 1. Is correct. See reasons from incorrect answers
    > 1. Is not correct. This is exploratory testing

1. Which one of the following options is categorized as a black-box test technique?
    1. [ ] A technique based on analysis of the architecture
    1. [ ] A technique checking that the test object is working according to the detailed design
    1. [ ] A technique based on the knowledge of past faults, or general knowledge of failures
    1. [x] A technique based on formal requirements

    > ### Explanation / Rationale
    > 1. Is not correct. This is a white-box test technique
    > 1. Is not correct. This is a white-box test technique
    > 1. Is not correct. This is an experience-based test technique
    > 1. Is correct. Black-box test techniques are based on an analysis of the appropriate test basis (e.g., formal requirements documents, specifications, use cases, user stories)

1. The following statement refers to decision coverage:
“When the code contains only a single ‘if’ statement and no loops or CASE statements, and its execution is not nested within the test, any single test case we run will result in 50% decision coverage.”

    Which of the following statement is correct?
    1. [ ] The statement is true. Any single test case provides 100% statement coverage and
therefore 50% decision coverage
    1. [ ] The statement is true. Any single test case would cause the outcome of the “if” statement to
be either true or false
    1. [ ] The statement is false. A single test case can only guarantee 25% decision coverage in this
case
    1. [ ] The statement is false. The statement is too broad. It may be correct or not, depending on
the tested software
1. Which one of the following is the description of statement coverage?
    1. [ ] It is a metric, which is the percentage of test cases that have been executed
    1. [ ] It is a metric, which is the percentage of statements in the source code that have been
executed
    1. [ ] It is a metric, which is the number of statements in the source code that have been
executed by test cases that are passed
    1. [ ] It is a metric, that gives a true/false confirmation if all statements are covered or not
1. Which statement about the relationship between statement coverage and decision coverage is
true?
    1. [ ] 100% decision coverage also guarantees 100% statement coverage
    1. [ ] 100% statement coverage also guarantees 100% decision coverage
    1. [ ] 50% decision coverage also guarantees 50% statement coverage
    1. [ ] Decision coverage can never reach 100%
1. Question #24 (1 Point)
For which of the following situations is exploratory testing suitable?
    1. [ ] When time pressure requires speeding up the execution of tests already specified
    1. [ ] When the system is developed incrementally, and no test charter is available
    1. [ ] When testers are available who have enough knowledge of similar applications and
technologies
    1. [ ] When an advanced knowledge of the system already exists, and evidence is to be if it
should be tested intensively
1. An employee’s bonus is to be calculated. It cannot be negative, but it can be calculated down to
zero. The bonus is based on the length of employment:
• Less than or equal to 2 years
• More than 2 years but less than 5 years
• 5 to 10 years inclusively
• Longer than 10 years
What is the minimum number of test cases required to cover all valid equivalence partitions for
calculating the bonus?
    1. [ ] 3
    1. [ ] 5
    1. [ ] 2
    1. [ ] 4
1. A speed control and reporting system has the following characteristics:
• If you drive 50 km/h or less, nothing will happen.
• If you drive faster than 50 km/h, but no more than 55 km/h, you will be warned.
• If you drive faster than 55 km/h but not more than 60 km/h, you will be fined.
• If you drive faster than 60 km/h, your driving license will be suspended.
• The speed in km/h is available to the system as an integer value.
Which would be the most likely set of values (km/h) identified by applying the boundary value
analysis, where only the values on the boundaries of the equivalence classes are selected?
    1. [ ] 0, 49, 50, 54, 59, 60
    1. [ ] 50, 55, 60
    1. [ ] 49, 50, 54, 55, 60, 62
    1. [ ] 50, 51, 55, 56, 60, 61
1. A company's employees are paid bonuses if they work more than a year in the company and
achieve a target which is individually agreed before.
These facts can be shown in a decision table:

    Test-ID |  | T1 | T2 | T3 | T4
    --- | --- | --- | --- | --- | ---
    Condition1 | Employment for more than 1 year? | YES | NO | NO | YES
    Condition2 | Agreed target? | NO | NO | YES | YES
    Condition3 | Achieved target? | NO | NO | YES | YES
    Action | Bonus payment | NO | NO | NO | YES

    Which of the following test cases represents a situation that can happen in real life, and is missing in the above decision table?
    1. [ ] Condition1 = YES, Condition2 = NO, Condition3 = YES, Action= NO
    1. [ ] Condition1 = YES, Condition2 = YES, Condition3 = NO, Action= YES
    1. [ ] Condition1 = NO, Condition2 = NO, Condition3 = YES, Action= NO
    1. [ ] Condition1 = NO, Condition2 = YES, Condition3 = NO, Action= NO
1. Which of the following statements about the given state transition diagram and table of test cases is TRUE?

    Test Case | 1 | 2 | 3 | 4 | 5
    --- | --- | --- | --- | --- | --- |
    Start State | S1 | S2 | S2 | S3 | S3
    Input | Power On | Power Off | RC On | RC Off | Power Off
    Expected Final State | S2 | S1 | S3 | S2 | S1

    1. [ ] The given test cases cover both valid and invalid transitions in the state transition diagram
    1. [ ] The given test cases represent all possible valid transitions in the state transition diagram
    1. [ ] The given test cases represent some of the valid transitions in the state transition diagram
    1. [ ] The given test cases represent pairs of transitions in the state transition diagram
1. A video application has the following requirement: The application shall allow playing a video on the following display resolution:
    ```
    1. 640x480
    2. 1280x720
    3. 1600x1200
    4. 1920x1080
    ```
    Which of the following list of test cases is a result of applying the equivalence partitioning test technique to test this requirement?
    1. [ ] Verify that the application can play a video on a display of size 1920x1080 (1 test case)
    1. [ ] Verify that the application can play a video on a display of size 640x480 and 1920x1080 (2
test cases)
    1. [ ] Verify that the application can play a video on each of the display sizes in the requirement
(4 test cases)
    1. [ ] Verify that the application can play a video on any one of the display sizes in the
requirement (1 test case)
1. Which of the following statements BEST describes how tasks are divided between the test
manager and the tester?
    1. [ ] The test manager plans testing activities and chooses the standards to be followed, while
the tester chooses the tools and set the tools usage guidelines
    1. [ ] The test manager plans, coordinates, and controls the testing activities, while the tester
automates the tests
    1. [ ] The test manager plans, monitors, and controls the testing activities, while the tester
designs tests and decides on the release of the test object
    1. [ ] The test manager plans and organizes the testing and specifies the test cases, while the tester executes the tests
1. Which of the following metrics would be MOST useful to monitor during test execution?
    1. [ ] Percentage of executed test cases
    1. [ ] Average number of testers involved in the test execution
    1. [ ] Coverage of requirements by source code
    1. [ ] Percentage of test cases already created and reviewed
1. Which of the following can affect and be part of the (initial) test planning?
    1. [ ] Budget limitations
    1. [ ] Test log
    1. [ ] Failure rate
    1. [ ] Use cases
1. Which of the following lists contains only typical exit criteria from testing?
    1. [ ] Reliability measures, test coverage, schedule and status about fixing defect and remaining
risks
    1. [ ] Reliability measures, test coverage, degree of tester’s independence and product
completeness
    1. [ ] Reliability measures, test coverage, test cost, availability of test environment, time to
market and product completeness
    1. [ ] Time to market, remaining defects, tester qualification, availability of testable use cases, test coverage and test cost
1. Which one of the following is NOT included in a test summary report?
    1. [ ] Defining pass/fail criteria and objectives of testing
    1. [ ] Deviations from the test approach
    1. [ ] Measurements of actual progress against exit criteria
    1. [ ] Evaluation of the quality of the test object
1. The project develops a "smart" heating thermostat. The control algorithms of the thermostat were modeled as Matlab/Simulink models and run on the internet connected server. The thermostat
uses the specifications of the server to trigger the heating valves.
The test manager has defined the following test strategy/approach in the test plan:
    ```
    1. The acceptance test for the whole system is executed as an experience-based test.
    2. The control algorithms on the server are checked against standard of the energy
    saving regulation.
    3. The functional test of the thermostat is performed as risk-based testing.
    4. The security tests of data / communication via the internet are executed together
    with external security experts.
    ```
    What four common types of test strategies/approaches did the test manager implement in the test
    plan?
    1. [ ] Methodical, analytical, reactive, and regression-averse
    1. [ ] Analytical, standard-compliant, consultative, and reactive
    1. [ ] Model-based, methodical, analytical, and consultative
    1. [ ] Regression-averse, consultative, reactive, and methodical
1. Which one of the following is the characteristic of a metrics-based approach for test estimation?
    1. [ ] Budget which was used by a previous similar test project
    1. [ ] Overall experience collected in interviews with test managers
    1. [ ] Estimation of effort for test automation agreed in the test team
    1. [ ] Average of calculations collected from business experts
1. As a test manager you are responsible for testing the following parts of requirements:
    ```
    • R1 - Process anomalies
    • R2 - Synchronization
    • R3 - Approval
    • R4 - Problem solving
    • R5 - Financial data
    • R6 - Diagram data
    • R7 - Changes to the user profile
    ```
    Notation: Logical requirement dependencies (A -> B means, that B depends on     1. [ ]:
Which one of the following options structures the test execution schedule according to the
requirement dependencies?
    1. [ ] R1 ; R3 ; R4 ; R7 ; R2 ; R5 ; R6
    1. [ ] R1 ; R3 ; R2 ; R4 ; R7 ; R5 ; R6
    1. [ ] R1 ; R3 ; R2 ; R5 ; R6 ; R4 ; R7
    1. [ ] R1 ; R2 ; R5 ; R6 ; R3 ; R4 ; R7
1. You are testing a new version of software for a coffee machine. The machine can prepare different types of coffee based on four categories. i.e., coffee size, sugar, milk, and syrup. The criteria are as follows:
    ```
    • Coffee size (small, medium, large)
    • Sugar (none, 1 unit, 2 units, 3 units, 4 units)
    • Milk (yes or no)
    • Coffee flavor syrup (no syrup, caramel, hazelnut, vanilla)
    ```
    Now you are writing a defect report with the following information:
    ```
    • Title: Low coffee temperature.
    • Short summary: When you select coffee with milk, the time for preparing coffee is too long and the temperature of the beverage is too low (less than 40 °C).
    • Expected result: The temperature of coffee should be standard (about 75 °C).
    • Degree of risk: Medium
    • Priority: Normal
    ```
    What valuable information was omitted in the above defect report?
    1. [ ] The actual test results
    1. [ ] Identification of the tested software version
    1. [ ] Status of the defect
    1. [ ] Ideas for improving the test case
1. Which one of the following is MOST likely to be a benefit of test execution tools?
    1. [ ] It is easy to create regression tests
    1. [ ] It is easy to maintain version control of test assets
    1. [ ] It is easy to design tests for security testing
    1. [ ] It is easy to run regression tests
1. Which one of the following test tools is mostly suitable for developers rather than testers?
    1. [ ] Requirement management tools
    1. [ ] Configuration management tools
    1. [ ] Static analysis tools
    1. [ ] Performance testing tools
