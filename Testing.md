# Fundamentals
The Sample Exam Q&A Set originates from [ISTQB Certified tester foundation level](https://www.istqb.org/certifications/certified-tester-foundation-level) and is here for searchability and quotations to allow faster learning. Visit their site for the most up-to-date version.
## Sample Exam set A | Version 1.7
(1 Point) Select ONE option.

1. ### Which one of the following answers describes a **test condition**?
    1. [ ] A distinguishing characteristic of a component or system
    1. [x] A testable aspect of a component or system identified as a basis for testing
    1. [ ] The degree to which a software product provides functions which meet stated and implied needs when the software is used under specified conditions
    1. [ ] Test cases designed to execute combinations of conditions and actions resulting from them
    
    > #### Explanation / Rationale
    > 1. Is not correct. Definition of **feature** according to glossary
    > 1. Is correct. From glossary
    > 1. Is not correct. Definition of functionality **suitability** according to glossary
    > 1. Is not correct. Like Definition of **Decision table testing** according to glossary

1. ### Which of the following statements is a valid objective for testing?
    1. [ ] The test should start as late as possible so that development had enough time to create a good product
    1. [x] To validate whether the test object works as expected by the users and other stakeholders
    1. [ ] To prove that all possible defects are identified
    1. [ ] To prove that any remaining defects will not cause any failures

    > #### Explanation / Rationale
    > 1. Is not correct. Contradiction to principle 3: “Early testing saves time and money”
    > 1. Is correct. This is one objective of testing
    > 1. Is not correct. Principle #2 states that exhaustive testing is impossible, so one can never prove that all defects were identified
    > 1. Is not correct. To make an assessment whether a defect will cause a failure or not, one must detect the defect first. Saying that no remaining defect will cause a failure implicitly means that all defects were found. This again contradicts principle #2

1. ### Which of the following statements correctly describes the difference between testing and debugging?
    1. [ ] Testing identifies the source of defects; debugging analyzes the defects and proposes prevention activities
    1. [x] Dynamic testing shows failures caused by defects; debugging eliminates the defects, which are the source of failures
    1. [ ] Testing removes faults; but debugging removes defects that cause the faults
    1. [ ] Dynamic testing prevents the causes of failures; debugging removes the failures

    > #### Explanation / Rationale
    > 1. Is not correct. Testing does not identify the source of defects, debugging identifies the source of defects
    > 1. Is correct. Dynamic testing can show failures that are caused by defects in the software. Debugging eliminates the defects, which are the source of failures
    > 1. Is not correct. Testing does not remove faults, but debugging removes faults, which is synonyms for defects, that may cause the failures
    > 1. Is not correct. Dynamic testing does not directly prevent the causes of failures (defects) but detects the presence of defects

1. ### Which one of the statements below describes the most common situation for a failure discovered during testing or in production?
    1. [x] The product crashed when the user selected an option in a dialog box
    1. [ ] The wrong version of a compiled source code file was included in the build
    1. [ ] The computation algorithm used the wrong input variables
    1. [ ] The developer misinterpreted the requirement for the algorithm

    > #### Explanation / Rationale
    > 1. Is correct. A crash is clearly noticeable by the user
    > 1. Is not correct. This is a defect, not a failure since there is something wrong in the code. It may not result in a visible or noticeable failure, for example if the changes in the source code file are only in comments
    > 1. Is not correct. The use of wrong input variables may not result in a visible or noticeable failure, for example if nobody uses this particular algorithm; or if the wrong input variable has a similar value to the correct input variable; or if the FALSE result of the algorithm is not used
    > 1. Is not correct. This type of fault will not necessarily lead to a failure; for example, if no one uses this special algorithm

1. ### Mr. Test has been testing software applications on mobile devices for a period of 5 years. He has a wealth of experience in testing mobile applications and achieves better results in a shorter time than others. Over several months, Mr. Test did not modify the existing automated test cases and did not create any new test cases. This leads to fewer and fewer defects being found by executing the tests. What principle of testing did Mr. Test not observe?
    1. [ ] Testing depends on the environment
    1. [ ] Exhaustive testing is not possible
    1. [x] Repeating of same tests will not find new defects
    1. [ ] Defects cluster together

    > #### Explanation / Rationale
    > 1. Is not correct. Testing is context dependent, regardless of it being manual or automated (principle #6), but does not result in detecting a decreasing number of faults as described above
    > 1. Is not correct. Exhaustive testing is impossible, regardless of the amount of effort put into testing (principle #2)
    > 1. Is correct. Principle #5 says “If the same tests are repeated over and over again, eventually these tests no longer find any new defects. To detect new defects, existing tests and test data may need changing, and new tests may need to be written.” Automated regression testing of the same test cases will not bring new findings
    > 1. Is not correct. ”Defect cluster together” (principle #4). A small number of modules usually contain most of the defects, but this does not mean that fewer and fewer defects will be found

1. ### In what way can testing be part of Quality Assurance?
    1. [ ] It ensures that requirements are detailed enough
    1. [x] Testing reduces the risk of poor software quality
    1. [ ] It ensures that standards in the organization are followed
    1. [ ] It measures the quality of software in terms of number of executed test cases

    > #### Explanation / Rationale
    > 1. Is not correct. Static testing (reviews) contributes, but could not ensure, that requirements are detailed enough
    > 1. Is correct. Testing contributes to the achievement of quality in a variety of ways, e.g., such as reducing the risk of inadequate software quality
    > 1. Is not correct. This is quality assurance but not testing
    > 1. Is not correct. The quality cannot be measured by counting the number of executed test cases without knowing the outcome

1. ### Which of the following activities is part of the main activity "test analysis" in the test process?
    1. [ ] Identifying any required infrastructure and tools
    1. [ ] Creating test suites from test scripts
    1. [ ] Analyzing lessons learned for process improvement
    1. [x] Evaluating the test basis for testability

    > #### Explanation / Rationale
    > 1. Is not correct. This activity is performed during the test design activity (test design)
    > 1. Is not correct. This activity is performed during the test implementation activity (test implementation)
    > 1. Is not correct. This activity is performed during the test completion activity (test completion)
    > 1. Is correct. This activity is performed during the test analysis activity (test analysis)

1. ### Match the following test work products (1-4) with the right description (A-D).
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

    > #### Explanation / Rationale
    > Glossary defines the following tests as:
    > * Test suite: “A set of test scripts or test procedures to be executed in a specific test run.” (1A)
    > * Test case: “A set of preconditions, inputs, actions (where applicable), expected results and post conditions, developed based on test conditions” (2C)
    > * Test script: “A sequence of instructions for the execution of a test” (3B)
    > * Test charter: “Documentation of test activities in session-based exploratory testing” (4D)

1. ### How can white-box testing be applied during user acceptance testing?
    1. [ ] To check if large volumes of data can be transferred between integrated systems
    1. [ ] To check if all code statements and code decision paths have been executed
    1. [x] To check if all work process flows have been covered
    1. [ ] To cover all web page navigations

    > #### Explanation / Rationale
    > 1. Is not correct. Relevant for integration testing
    > 1. Is not correct. Relevant for component testing
    > 1. Is correct. For acceptance testing, tests are designed to cover all workflows defined in the functional requirements documents.
    > 1. Is not correct. Relevant for system testing

1. ### Which of the following statements comparing component testing and system testing is TRUE?
    1. [ ] Component testing verifies the functionality of software modules, program objects, and classes that are separately testable, whereas system testing verifies interfaces between components and interactions between different parts of the system
    1. [x] Test cases for component testing are usually derived from component specifications, design specifications, or data models, whereas test cases for system testing are usually derived from requirement specifications or use cases
    1. [ ] Component testing only focuses on functional characteristics, whereas system testing focuses on functional and non-functional characteristics
    1. [ ] Component testing is the responsibility of the testers, whereas system testing typically is the responsibility of the users of the system

    > #### Explanation / Rationale
    > 1. Is not correct. System testing does not test interfaces between components and interactions between different parts of the system; this is a target of integration tests
    > 1. Is correct. Examples of work products that can be used as a test basis for component testing include detailed design, code, data model,component specifications. Examples of work products for system testing include system and software requirement specifications (functional and non-functional) use cases
    > 1. Is not correct. Component testing does not ONLY focus on functional characteristics
    > 1. Is not correct. Component tests are also executed by developers, whereas system testing typically is the responsibility of (independent)testers

1. ### Which one of the following is TRUE?
    1. [ ] The purpose of regression testing is to check if the correction has been successfully implemented, while the purpose of confirmation testing is to confirm that the correction has no side effects
    1. [ ] The purpose of regression testing is to detect unintended side effects, while the purpose of confirmation testing is to check if the system is still working in a new environment
    1. [x] The purpose of regression testing is to detect unintended side effects, while the purpose of confirmation testing is to check if the original defect has been fixed
    1. [ ] The purpose of regression testing is to check if the new functionality is working, while the purpose of confirmation testing is to check if the original defect has been fixed

    > #### Explanation / Rationale
    > 1. Is not correct. Regression testing does not check successful implementation of corrections and confirmation testing does not check for side effects
    > 1. Is not correct. The statement about confirmation testing should be about regression testing
    > 1. Is correct. See reasons from incorrect answers
    > 1. Is not correct. Testing new functionality is not regression testing

1. ### Which one of the following is the BEST definition of an incremental development model?
    1. [x] Defining requirements, designing software and testing are done in phases where in each phase a piece of the system is added
    1. [ ] A phase in the development process should begin when the previous phase is complete
    1. [ ] Testing is viewed as a separate phase which takes place after development has been completed
    1. [ ] Testing is added to development as an increment

    > #### Explanation / Rationale
    > 1. Is correct. Incremental development involves establishing requirements, designing, building, and testing a system in pieces
    > 1. Is not correct. This is a sequential model
    > 1. Is not correct. This describes the waterfall model
    > 1. Is not correct. Testing alone is not an increment/additional step in the development

1. ### Which of the following should NOT be a trigger for maintenance testing?
    1. [x] Decision to test the maintainability of the software
    1. [ ] Decision to test the system after migration to a new operating platform
    1. [ ] Decision to test if archived data is possible to be retrieved
    1. [ ] Decision to test after “hot fixes”

    > #### Explanation / Rationale
    > 1. Is correct. This is maintainability testing, not maintenance testing
    > 1. Is not correct. This is a trigger for maintenance testing: Operational tests of the new environment as well as of the changed software
    > 1. Is not correct. This is the trigger for maintenance testing: testing restore/retrieve procedures after archiving for long retention periods
    > 1. Is not correct. This is the trigger for maintenance testing: Reactive modification of a delivered software product to correct emergency defects that have caused actual failures

1. ### Which of the following options are roles in a formal review?
    1. [ ] Developer, Moderator, Review leader, Reviewer, Tester
    1. [ ] Author, Moderator, Manager, Reviewer, Developer
    1. [ ] Author, Manager, Review leader, Reviewer, Designer
    1. [x] Author, Moderator, Review leader, Reviewer, Scribe

    > #### Explanation / Rationale
    > 1. Is not correct. Tester and developer are NOT roles in a formal review
    > 1. Is not correct. Developer is NOT a role in a formal review
    > 1. Is not correct. Designer is NOT a role in a formal review
    > 1. Is correct. See reasons from incorrect answers

1. ### Which activities are carried out within the planning of a formal review?
    1. [ ] Collection of metrics for the evaluation of the effectiveness of the review
    1. [ ] Answer any questions the participants may have
    1. [x] Definition and Verification of fulfillment of entry criteria for the review
    1. [ ] Evaluation of the review findings against the exit criteria

    > #### Explanation / Rationale
    > 1. Is not correct. ‘Collection of metrics’ belongs to the main activity “Fixing and Reporting”
    > 1. Is not correct. ‘Answer any question.’ belongs to the main activity “Initiate Review”
    > 1. Is correct. The checking of entry criteria takes place in the planning of a formal review
    > 1. Is not correct. The evaluation of the review findings against the exit criteria belongs to the main activity “Issue communication and analysis”

1. ### Which of the review types below is the BEST option to choose when the review must follow a formal process based on rules and checklists?
    1. [ ] Informal Review
    1. [ ] Technical Review
    1. [x] Inspection
    1. [ ] Walkthrough

    > #### Explanation / Rationale
    > 1. Is not correct. Informal review does not use a formal process
    > 1. Is not correct. Use of checklists are optional
    > 1. Is correct. Inspection is a formal process based on rules and checklists
    > 1. Is not correct. Does not explicitly require a formal process and the use of checklists is optional

1. ### Which of the following statements about static testing are MOST true?
    1. [x] Static testing is a cheap way to detect and remove defects
    1. [ ] Static testing makes dynamic testing less challenging
    1. [ ] Static testing makes it possible to find run-time problems early in the lifecycle
    1. [ ] When testing safety-critical system, static testing has less value because dynamic testing finds the defects better

    > #### Explanation / Rationale
    > 1. Is correct. Defects found early are often much cheaper to remove than defects detected later in the lifecycle
    > 1. Is not correct. Dynamic testing still has its challenging because they find other types of defects
    > 1. Is not correct. This is dynamic testing
    > 1. Is not correct. Static testing is important for safety-critical computer systems

1. ### You will be invited to a review. The work product to be reviewed is a description of the in-house document creation process. The aim of the description is to present the work distribution between the different roles involved in the process in a way that can be clearly understood by everyone. You will be invited to a checklist-based review. The checklist will also be sent to you. It includes the following points:
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

    > #### Explanation / Rationale
    > 1. Is not correct. It is described that the software architect must have completed the system specification
    > 1. Is not correct. ‘Checklist-based’, last sentence it is documented that you should also look for defects outside the checklist
    > 1. Is not correct. It is described: every reviewer did his review done comment
    > 1. Is correct. It is described that a checklist is available, but who provides the checklist?

1. ### What is checklist-based testing?
    1. [ ] A test technique in which tests are derived based on the tester's knowledge of past faults, or general knowledge of failures
    1. [ ] A test technique based on an analysis of the specification of a component or system
    1. [x] An experience-based test technique whereby the experienced tester uses a list of items to be noted, checked, or remembered, or a set of rules or criteria against which a product must be verified
    1. [ ] An approach to testing where the testers dynamically design and execute tests based on their knowledge, exploration of the test item and the results of previous tests

    > #### Explanation / Rationale
    > 1. Is not correct. This is error guessing
    > 1. Is not correct. This is black-box test technique
    > 1. Is correct. See reasons from incorrect answers
    > 1. Is not correct. This is exploratory testing

1. ### Which one of the following options is categorized as a black-box test technique?
    1. [ ] A technique based on analysis of the architecture
    1. [ ] A technique checking that the test object is working according to the detailed design
    1. [ ] A technique based on the knowledge of past faults, or general knowledge of failures
    1. [x] A technique based on formal requirements

    > #### Explanation / Rationale
    > 1. Is not correct. This is a white-box test technique
    > 1. Is not correct. This is a white-box test technique
    > 1. Is not correct. This is an experience-based test technique
    > 1. Is correct. Black-box test techniques are based on an analysis of the appropriate test basis (e.g., formal requirements documents, specifications, use cases, user stories)

1. ### The following statement refers to decision coverage:
    “When the code contains only a single ‘if’ statement and no loops or CASE statements, and its execution is not nested within the test, any single test case we run will result in 50% decision coverage.”

    Which of the following statement is correct?
    1. [ ] The statement is true. Any single test case provides 100% statement coverage and therefore 50% decision coverage
    1. [x] The statement is true. Any single test case would cause the outcome of the “if” statement to be either true or false
    1. [ ] The statement is false. A single test case can only guarantee 25% decision coverage in this case
    1. [ ] The statement is false. The statement is too broad. It may be correct or not, depending on the tested software

    > #### Explanation / Rationale
    > 1. Is not correct. While the given statement is true, the explanation is not. The relationship between statement and decision coverage is misrepresented
    > 1. Is correct. Since any test case will cause the outcome of the “if” statement to be either TRUE or FALSE, by definition we achieved 50% decision coverage
    > 1. Is not correct. A single test case can give more than 25% decision coverage, this means according to the statement above always 50 % decision coverage
    > 1. Is not correct. The statement is specific and always true, because each test case achieves 50 % decision coverage

1. ### Which one of the following is the description of statement coverage?
    1. [ ] It is a metric, which is the percentage of test cases that have been executed
    1. [x] It is a metric, which is the percentage of statements in the source code that have been executed
    1. [ ] It is a metric, which is the number of statements in the source code that have been executed by test cases that are passed
    1. [ ] It is a metric, that gives a true/false confirmation if all statements are covered or not

    > #### Explanation / Rationale
    > 1. Is not correct. Statement coverage measures the percentage of statements exercised by test cases
    > 1. Is correct. Statement testing exercises the executable statements in the code. Statement coverage is measured as the number of statements executed by the tests divided by the total number of executable statements in the test object, normally expressed as a percentage
    > 1. Is not correct. The coverage does not measure pass/fail
    > 1. Is not correct. It is a metric and does not provide true/false statements

1. ### Which statement about the relationship between statement coverage and decision coverage is true?
    1. [x] 100% decision coverage also guarantees 100% statement coverage
    1. [ ] 100% statement coverage also guarantees 100% decision coverage
    1. [ ] 50% decision coverage also guarantees 50% statement coverage
    1. [ ] Decision coverage can never reach 100%

    > #### Explanation / Rationale
    > 1. Is correct. The statement is true. Achieving 100% decision coverage guarantees 100% statement coverage
    > 1. Is not correct. The statement is false because achieving 100 % statement coverage does not in any case mean that the decision coverage is 100%
    > 1. Is not correct. The statement is false because we can only do statements about 100% values
    > 1. Is not correct. The statement is false

1. #### For which of the following situations is exploratory testing suitable?
    1. [ ] When time pressure requires speeding up the execution of tests already specified
    1. [ ] When the system is developed incrementally, and no test charter is available
    1. [x] When testers are available who have enough knowledge of similar applications and technologies
    1. [ ] When an advanced knowledge of the system already exists, and evidence is to be if it should be tested intensively

    > #### Explanation / Rationale
    > 1. Is not correct. Exploratory testing is not suitable to speed up tests, which are already specified. It is most useful when there are few or inappropriate specified requirements or significant time pressure on testing
    > 1. Is not correct. The absence of a test charter, which may have been derived from the test analysis, is a poor precondition for the use of exploratory testing
    > 1. Is correct. Exploratory tests should be performed by experienced testers with knowledge of similar applications and technologies
    > 1. Is not correct. Explorative testing alone is not suitable to provide evidence that the test was very intensive, instead the evidence is provided in combination with other test methods

1. ### An employee’s bonus is to be calculated. It cannot be negative, but it can be calculated down to zero. The bonus is based on the length of employment:
    ```
    • Less than or equal to 2 years
    • More than 2 years but less than 5 years
    • 5 to 10 years inclusively
    • Longer than 10 years
    ```
    What is the minimum number of test cases required to cover all valid equivalence partitions for calculating the bonus?
    1. [ ] 3
    1. [ ] 5
    1. [ ] 2
    1. [x] 4

    > #### Explanation / Rationale
    > 1. Is not correct. One too few (see the four correct partitions in the correct answer)
    > 1. Is not correct. One too much (see the four correct partitions in the correct answer)
    > 1. Is not correct. Two too few (see the four correct partitions in the correct answer)
    > 1. Is correct. The 4 equivalence partitions correspond to the description in the question, i.e., at least one test case must be created for each equivalence partition:
    >
    >     1. Equivalence partition: 0 ≤ employment time ≤ 2
    >     2. Equivalence partition: 2 < employment time < 5
    >     3. Equivalence partition: 5 ≤ employment time ≤ 10
    >     4. Equivalence partition: 10 < employment time

1. ### A speed control and reporting system has the following characteristics:
    
    * If you drive 50 km/h or less, nothing will happen.
    * If you drive faster than 50 km/h, but no more than 55 km/h, you will be warned.
    * If you drive faster than 55 km/h but not more than 60 km/h, you will be fined.
    * If you drive faster than 60 km/h, your driving license will be suspended.
    * The speed in km/h is available to the system as an integer value.
    
    Which would be the most likely set of values (km/h) identified by applying the boundary value analysis, where only the values on the boundaries of the equivalence classes are selected?
    1. [ ] 0, 49, 50, 54, 59, 60
    1. [ ] 50, 55, 60
    1. [ ] 49, 50, 54, 55, 60, 62
    1. [x] 50, 51, 55, 56, 60, 61

    > #### Explanation / Rationale
    > The following partitions can be identified:
    > * <= 50, boundary value 50
    > * 51 – 55 boundary values 51, 55
    > * 56 – 60 boundary values 56, 60
    > * &gt;= 61 boundary value 61
    >
    > Boundary value according to glossary V.3.2: A minimum or maximum value of an ordered equivalence partition.
    >
    > Thus:
    > 1. Is not correct. Does not include all necessary boundary values, but it includes additional values: 0, 49, and 59, which are not boundary values in this equivalence partition
    > 1. Is not correct. Does not include all necessary boundary values. 51 and 55 are missing
    > 1. Is not correct. Does not include necessary boundary values but it includes additional values: 49, 62, and 54, which are not boundary values in this equivalence partition
    > 1. Is correct. includes all necessary boundary values

1. ### A company's employees are paid bonuses if they work more than a year in the company and achieve a target which is individually agreed before. These facts can be shown in a decision table:

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
    1. [x] Condition1 = NO, Condition2 = YES, Condition3 = NO, Action= NO

    > #### Explanation / Rationale
    > 1. Is not correct. If there was no agreement on targets, it is impossible to reach the targets. Since this situation can´t occur, this is not a scenario happening in reality
    > 1. Is not correct. The test case is objectively wrong, since under these conditions no bonus is paid because the agreed target was not reached
    > 1. Is not correct. There was no agreement on targets, it is impossible to reach the targets. Since this situation can´t occur, this is not a scenario happening in reality
    > 1. Is correct. The test case describes the situation that the too short period of employment and the non-fulfilment of the agreed target leads to nonpayment of the bonus. This situation can occur in practice but is missing in the decision table

1. ### Which of the following statements about the given state transition diagram and table of test cases is TRUE?

    Test Case | 1 | 2 | 3 | 4 | 5
    --- | --- | --- | --- | --- | --- |
    Start State | S1 | S2 | S2 | S3 | S3
    Input | Power On | Power Off | RC On | RC Off | Power Off
    Expected Final State | S2 | S1 | S3 | S2 | S1

    1. [ ] The given test cases cover both valid and invalid transitions in the state transition diagram
    1. [x] The given test cases represent all possible valid transitions in the state transition diagram
    1. [ ] The given test cases represent some of the valid transitions in the state transition diagram
    1. [ ] The given test cases represent pairs of transitions in the state transition diagram

    > #### Explanation / Rationale
    > Proposed test case covers all five possible single valid transitions in the given state diagram (S1->S2, S2->S1, S2->S3, S3->S2, and S3->S1).
    >
    >Thus:
    > 1. Is not correct. Because no invalid transitions are covered
    > 1. Is correct. Because all valid transitions are covered
    > 1. Is not correct. Because all valid transitions are covered
    > 1. Is not correct. Because the test cases do not have pairs of transitions specified

1. ### A video application has the following requirement: The application shall allow playing a video on the following display resolution:
    ```
    1. 640x480
    2. 1280x720
    3. 1600x1200
    4. 1920x1080
    ```
    Which of the following list of test cases is a result of applying the equivalence partitioning test technique to test this requirement?
    1. [ ] Verify that the application can play a video on a display of size 1920x1080 (1 test case)
    1. [ ] Verify that the application can play a video on a display of size 640x480 and 1920x1080 (2 test cases)
    1. [x] Verify that the application can play a video on each of the display sizes in the requirement (4 test cases)
    1. [ ] Verify that the application can play a video on any one of the display sizes in the requirement (1 test case)

    > #### Explanation / Rationale
    > 1. Is not correct. See reason from correct answer
    > 1. Is not correct. See reason from correct answer
    > 1. Is correct. This is a case where the requirement gives an enumeration of discrete values. Each enumeration value is an equivalence class by itself; therefore, each will be tested when using equivalence partitioning test technique
    > 1. Is not correct. See reason from correct answer

1. ### Which of the following statements BEST describes how tasks are divided between the test manager and the tester?

    1. [ ] The test manager plans testing activities and chooses the standards to be followed, while the tester chooses the tools and set the tools usage guidelines
    1. [x] The test manager plans, coordinates, and controls the testing activities, while the tester automates the tests
    1. [ ] The test manager plans, monitors, and controls the testing activities, while the tester designs tests and decides on the release of the test object
    1. [ ] The test manager plans and organizes the testing and specifies the test cases, while the tester executes the tests

    > #### Explanation / Rationale
    > 1. Is not correct. Selection of tools is a test manager task
    > 1. Is correct. See reasons from incorrect answers
    > 1. Is not correct. The tester does not decide on the release of the test object
    > 1. Is not correct. The tester specifies the test cases, the test manager does the prioritization

1. ### Which of the following metrics would be MOST useful to monitor during test execution?
    1. [x] Percentage of executed test cases
    1. [ ] Average number of testers involved in the test execution
    1. [ ] Coverage of requirements by source code
    1. [ ] Percentage of test cases already created and reviewed

    > #### Explanation / Rationale
    > 1. Is correct. Test case execution (e.g., number of test cases run/not run, and test cases passed/failed)
    > 1. Is not correct. This metric can be measured, but its value is low. The number of testers does not give any information about the quality of the test object or test progress
    > 1. Is not correct. the coverage of requirements by source code is not measured during test execution. At most, the TEST(!) coverage of the code or requirements is measured
    > 1. Is not correct. This metric is part of test preparation and not test execution

1. ### Which of the following can affect and be part of the (initial) test planning?
    1. [x] Budget limitations
    1. [ ] Test log
    1. [ ] Failure rate
    1. [ ] Use cases

    > #### Explanation / Rationale
    > 1. Is correct. Making decisions about what to test are documented in the test plan. This means when you are planning the test and there are budget limitations, prioritizing is needed; what should be tested and what should be omitted
    > 1. Is not correct. Test monitoring and control
    > 1. Is not correct. Common test metrics
    > 1. Is not correct. It is a part of test analysis

1. ### Which of the following lists contains only typical exit criteria from testing?
    1. [x] Reliability measures, test coverage, schedule and status about fixing defect and remaining risks
    1. [ ] Reliability measures, test coverage, degree of tester’s independence and product completeness
    1. [ ] Reliability measures, test coverage, test cost, availability of test environment, time to market and product completeness
    1. [ ] Time to market, remaining defects, tester qualification, availability of testable use cases, test coverage and test cost

    > #### Explanation / Rationale
    > 1. Is correct. See reasons from incorrect answers
    > 1. Is not correct. The “degree of tester’s independence” does not play a role in exit criteria
    > 1. Is not correct. “Availability of test environment” is an entry criterion
    > 1. Is not correct. “The Qualification of Tester” is not a typical exit criterion

1. ### Which one of the following is NOT included in a test summary report?
    1. [x] Defining pass/fail criteria and objectives of testing
    1. [ ] Deviations from the test approach
    1. [ ] Measurements of actual progress against exit criteria
    1. [ ] Evaluation of the quality of the test object

    > #### Explanation / Rationale
    > 1. Is correct. This information has been defined earlier in the test project
    > 1. Is not correct. This information is included in a test report: information on what occurred during a test period
    > 1. Is not correct. This information is included in a test report:
    >    * Status of testing and product quality with respect to the exit criteria or definition of done
    >    * Metrics of defects, test cases, test coverage, activity progress, and resource consumption
    > 1. Is not correct. This information is included in a test report: Information and metrics to support recommendations and decisions about future actions, such as an assessment of defects remaining, the economic benefit of continued testing, outstanding risks, and the level of confidence in the tested software

1. ### The project develops a "smart" heating thermostat. The control algorithms of the thermostat were modeled as Matlab/Simulink models and run on the internet connected server. The thermostat uses the specifications of the server to trigger the heating valves. The test manager has defined the following test strategy/approach in the test plan:
    
    1. The acceptance test for the whole system is executed as an experience-based test.
    2. The control algorithms on the server are checked against standard of the energy
    saving regulation.
    3. The functional test of the thermostat is performed as risk-based testing.
    4. The security tests of data / communication via the internet are executed together
    with external security experts.
    
    What four common types of test strategies/approaches did the test manager implement in the test
    plan?
    1. [ ] Methodical, analytical, reactive, and regression-averse
    1. [x] Analytical, standard-compliant, consultative, and reactive
    1. [ ] Model-based, methodical, analytical, and consultative
    1. [ ] Regression-averse, consultative, reactive, and methodical

    > #### Explanation / Rationale
    > The possible mappings of points 1 to 4 can be justified as follows:
    > 1. Approach 3 is analytical: Risk-based testing is an example of an analytical approach, where tests are designed and prioritized based on the level of risk
    > 1. Approach 2 is standard-compliant: The control algorithms is checked against industry-specific standard of the energy saving regulation.
    > 1. Approach 4 is consultative: This type of test strategy is driven primarily by the advice, guidance, or instructions of stakeholders, business domain experts, or technology experts, who may be outside the test team or outside the organization itself
    > 1. Approach 1 is reactive: Exploratory testing is a common technique employed in reactive strategies, whereby the explorative testing isassigned to the experience-based testing category

1. ### Which one of the following is the characteristic of a metrics-based approach for test estimation?
    1. [x] Budget which was used by a previous similar test project
    1. [ ] Overall experience collected in interviews with test managers
    1. [ ] Estimation of effort for test automation agreed in the test team
    1. [ ] Average of calculations collected from business experts

    > #### Explanation / Rationale
    > 1. Is correct. The metrics-based approach: estimating the testing effort based on metrics of former similar projects or based on typical values
    > 1. Is not correct. This is expert-based approach: estimating the tasks based on estimates made by the owners of the tasks or by experts
    > 1. Is not correct. This is expert-based approach: estimating the tasks based on estimates made by the responsible team of the tasks or by experts
    > 1. Is not correct. This is expert-based approach: estimating the tasks based on estimates made by the owners of the tasks or by experts

1. ### As a test manager you are responsible for testing the following parts of requirements:

    * R1 - Process anomalies
    * R2 - Synchronization
    * R3 - Approval
    * R4 - Problem solving
    * R5 - Financial data
    * R6 - Diagram data
    * R7 - Changes to the user profile

    Notation: Logical requirement dependencies (A -> B means, that B depends on A). Which one of the following options structures the test execution schedule according to the requirement dependencies?
    1. [ ] R1 ; R3 ; R4 ; R7 ; R2 ; R5 ; R6
    1. [ ] R1 ; R3 ; R2 ; R4 ; R7 ; R5 ; R6
    1. [x] R1 ; R3 ; R2 ; R5 ; R6 ; R4 ; R7
    1. [ ] R1 ; R2 ; R5 ; R6 ; R3 ; R4 ; R7

    > #### Explanation / Rationale
    > 1. Is not correct. R4 is dependent on R2, so R2 should be tested before R4
    > 1. Is not correct. R4 is dependent on R2, R5 and R6, so R5 and R6 should be tested before R4
    > 1. Is correct. The tests are specified in a sequence that takes the dependencies into account
    > 1. Is not correct. R2 is dependent on R3, so R3 should be tested before R2

1. ### You are testing a new version of software for a coffee machine. The machine can prepare different types of coffee based on four categories. i.e., coffee size, sugar, milk, and syrup. The criteria are as follows:
    
    * Coffee size (small, medium, large)
    * Sugar (none, 1 unit, 2 units, 3 units, 4 units)
    * Milk (yes or no)
    * Coffee flavor syrup (no syrup, caramel, hazelnut, vanilla)
    
    Now you are writing a defect report with the following information:
    
    * Title: Low coffee temperature.
    * Short summary: When you select coffee with milk, the time for preparing coffee is too long and the temperature of the beverage is too low (less than 40 °C).
    * Expected result: The temperature of coffee should be standard (about 75 °C).
    * Degree of risk: Medium
    * Priority: Normal
    
    What valuable information was omitted in the above defect report?
    1. [ ] The actual test results
    1. [x] Identification of the tested software version
    1. [ ] Status of the defect
    1. [ ] Ideas for improving the test case

    > #### Explanation / Rationale
    > 1. Is not correct. The test result is given in the short summary
    > 1. Is correct. When testing different versions of software, identifying information is necessary
    > 1. Is not correct. You are just writing the defect report; hence, the status is automatically open
    > 1. Is not correct. This information is useful for the tester but does not need to be included in the defect report

1. ### Which one of the following is MOST likely to be a benefit of test execution tools?
    1. [ ] It is easy to create regression tests
    1. [ ] It is easy to maintain version control of test assets
    1. [ ] It is easy to design tests for security testing
    1. [x] It is easy to run regression tests

    > #### Explanation / Rationale
    > 1. Is not correct. The benefits are not when creating regressions tests, more in executing them
    > 1. Is not correct. This is done by configuration management tools
    > 1. Is not correct. This needs specialized tools
    > 1. Is correct. Reduction in repetitive manual work (e.g., running regression tests, environment set up/tear down tasks, re-entering the same test data, and checking against coding standards), thus saving time

1. ### Which one of the following test tools is mostly suitable for developers rather than testers?
    1. [ ] Requirement management tools
    1. [ ] Configuration management tools
    1. [x] Static analysis tools
    1. [ ] Performance testing tools

    > #### Explanation / Rationale
    > 1. Is not correct. Requirement management tools are not particularly suitable for developers
    > 1. Is not correct. Configuration management tools are not particularly suitable for developers
    > 1. Is correct. Static analysis tools are especially suitable for developers
    > 1. Is not correct. Performance testing tools are not better suited for developers than for testers

# Performance Testing 
The Sample Exam Q&A Set originates from [https://www.istqb.org/certifications/performance-tester](https://www.istqb.org/certifications/performance-tester) and is here for searchability and quotations to allow faster learning. Visit their site for the most up-to-date version.
## Sample Exam set A | Version 1.2
(1 Point) Select ONE option.

1. ### Which of the following is an important principle in performance testing?
    1. [ ] The tests should be easy to create and understand
    1. [ ] The test results must be reproducible when the system under test is unchanged
    1. [ ] The tests should be executed in the production environment to provide the most accurate results
    1. [ ] The test results should match the stakeholders’ expectations for system performance

1. ### Which of the following is the best description of spike testing?
    1. [ ] It focuses on the ability of the system to handle loads that are gradually increased to reach the expected maximum
    1. [ ] It focuses on the ability of the system to handle loads that are at or beyond the expected peak load
    1. [ ] It focuses on the ability of the system to meet future efficiency requirements
    1. [ ] It focuses on the ability of the system to respond to quick and extreme changes in load

1. ### Which of the following is the best description of load testing?
    1. [ ] It focuses on the ability of the system to handle loads that are gradually increased to reach the expected maximum
    1. [ ] It focuses on the ability of the system to handle loads that are at or beyond the expected peak load
    1. [ ] It focuses on the ability of the system to meet future efficiency requirements
    1. [ ] It focuses on the ability of the system to respond to quick and extreme changes in load

1. ### Which of the following performance testing activities should occur during unit testing?
    1. [ ] Testing end-to-end behavior under various load conditions
    1. [ ] Testing data flows and workflows across interfaces
    1. [ ] Testing key use cases and workflows using a top-down approach
    1. [ ] Testing to evaluate resource utilization and potential bottlenecks

1. ### When is it appropriate to generate load via the application’s APIs?
    1. [ ] When a large number of testers are available who can represent the real users
    1. [ ] When testing must be conducted at the communications protocol level
    1. [ ] When the UI is likely to change but the transactions must be processed as if they were created through the UI
    1. [ ] When only small numbers of test instances are available

1. ### If you have an application that has a memory leak, what is the likely result you will see during performance testing?
    1. [ ] Response time will be consistently slow
    1. [ ] Response time will remain acceptable, but the error handling will degrade
    1. [ ] Response time will be slow, but only under heavy loads
    1. [ ] Response time will degrade over time

1. ### Which of the following is a true statement regarding tracking metrics for network latency during a performance test?
    1. [ ] High latency could indicate a network bandwidth problem that could negatively impact performance
    1. [ ] Low latency could indicate a network bandwidth problem that could negatively impact performance
    1. [ ] Network latency is difficult to track and should not be included in the performance metrics
    1. [ ] Network latency is too variable to be useful during performance tuning

1. ### Should performance test results be aggregated?
    1. [ ] Yes, this gives a better overall picture of the performance of the system and helps to identify trends
    1. [ ] Yes, this is the best way to focus on the outliers in the performance metrics
    1. [ ] No, the results should be analyzed individually so that all variations are understood
    1. [ ] No, the results from each test should be reported and tracked separately

1. ### In what way are log analysis tools helpful for collecting metrics?
    1. [ ] They monitor the systems while the performance tests are conducted and report on the behavior during the tests
    1. [ ] They create the system load and monitor the system performance
    1. [ ] They scan the various server logs and compile metrics for occurrences that were recorded during the test execution
    1. [ ] They write the performance results to the server logs for later manual analysis

1. ### Which of the following is a failure that would typically be found by conducting a spike test?
    1. [ ] The system performance gradually degrades
    1. [ ] The system provides inconsistent responses to errors
    1. [ ] The system handles a sudden burst of activity, but cannot resume a steady state
    1. [ ] The system performs well for the expected load, but cannot scale to a larger load

1. ### When applying the principal performance testing activities, when should risk identification and analysis occur?
    1. [ ] Test planning
    1. [ ] Test analysis and design
    1. [ ] Test implementation and execution
    1. [ ] Test closure

1. ### When applying the principal performance testing activities, when should the test cases be ordered into performance test procedures?
    1. [ ] Test planning
    1. [ ] Test analysis and design
    1. [ ] Test implementation and execution
    1. [ ] Test closure

1. ### Consider the following technical environments:
    1. Single computer
    2. Multi-tier system
    3. Distributed
    4. Virtualized
    5. Dynamic/Cloud-based
    6. Client/Server and Browser-based
    7. Mobile
    8. Embedded
    9. Mainframe

    Which of these is most likely to have a performance risk due to connectivity issues?
    1. [ ] 2, 3
    1. [ ] 7, 8
    1. [ ] 5, 6, 7, 9
    1. [ ] 2, 4, 5, 8

1. ### Consider the following technical environments:
    1. Virtualized
    2. Dynamic/Cloud-based
    3. Client/Server and Browser-based
    4. Mobile
    5. Embedded
    6. Mainframe

    Which of these is most likely to have a performance risk due to memory leaks?
    1. [ ] 1, 2, 3, 6
    1. [ ] 2, 3, 4, 5
    1. [ ] 1, 2, 4, 6
    1. [ ] 1, 3, 4, 5
1. ### If performance testing is being conducted for software that is written in C++, what do you need to monitor that would not be a concern if the software were written in Python?
    1. [ ] Memory use
    1. [ ] Network latency
    1. [ ] Connectivity
    1. [ ] Batch processing

1. ### You are working on a project that tracks health history information for patients across a region. The number of records handled by the system is in the millions due to the large number of patients in the region. Patient information must be accessible to doctors in offices, hospitals, and urgent care facilities. The information should be presented to the requestor within three seconds of request, particularly for patients with critical allergies and preconditions. 
    Given this information, when is the best time in the project to analyze and assess the performance risks?
    1. [ ] During the requirements phase and again just prior to executing the performance tests
    1. [ ] After design but prior to coding
    1. [ ] During system testing and again prior to the performance tests
    1. [ ] Repeatedly throughout the requirements, development, and performance testing

1. ### You are working on a project that tracks health history information for patients across a region. The number of records handled by the system is in the millions due to the large number of patients in the region. Patient information must be accessible to doctors in offices, hospitals, and urgent care facilities. The information should be presented to the requestor within three seconds of request, particularly for patients with critical allergies and preconditions.
    What is the best way to address the performance testing for the response time?
    1. [ ] Test from the UI with the full data set loaded to ensure the response time will be adequate when the database is loaded
    1. [ ] Test via the web services at the API level to ensure access to the data is fast enough without having the testing complicated by the UI
    1. [ ] Conduct a technical review of the database implementation and conduct a performance test from the UI with the full database loaded
    1. [ ] Conduct a network assessment to ensure there are no latency issues between the database server and the web servers, then test with a network scanner to ensure no collisions are occurring that might cause performance delays

1. ### You are working on a project that tracks health history information for patients across a region. The number of records handled by the system is in the millions due to the large number of patients in the region. Patient information must be accessible to doctors in offices, hospitals, and urgent care facilities. The information should be presented to the requestor within three seconds of request, particularly for patients with critical allergies and preconditions. 
    Which of the following is a technical objective for performance that could be applicable to this project?
    1. [ ] The response time must be within three seconds from the time the request is sent when there are 100 concurrent users making similar requests
    1. [ ] The system must be able to scale to 10 million patient records with no degradation in the performance
    1. [ ] The system must perform at or above the level of the legacy system when handling a similar load and responding to a similar request
    1. [ ] The response time must remain the same when the disaster recovery system is in use rather than the primary system and the switchover must cause no discernable downtime

1. ### You are working on a project that tracks health history information for patients across a region. The number of records handled by the system is in the millions due to the large number of patients in the region. Patient information must be accessible to doctors in offices, hospitals, and urgent care facilities. The information should be presented to the requestor within three seconds of request, particularly for patients with critical allergies and preconditions.
    You have been asked to write a performance test plan for this project. Which of the following is the information you will need to deal with the most critical performance objective?
    1. [ ] Who can access what data and how often will they do it
    1. [ ] How is user access authenticated and authorized
    1. [ ] Where will the data be stored and how much storage is available
    1. [ ] What is the expected use of the data after it has been presented to the user

1. ### You are working on a project that tracks health history information for patients across a region. The number of records handled by the system is in the millions due to the large number of patients in the region. Patient information must be accessible to doctors in offices, hospitals, and urgent care facilities. The information should be presented to the requestor within three seconds of request, particularly for patients with critical allergies and preconditions.
    You have been asked to prepare a presentation for the business stakeholders regarding your plan for performance testing. Which of the following is an example set of information that should be shared with these stakeholders?
    1. [ ] Once configured, the performance test system will require data loading. Once loaded, we will next proceed to running a small set of sample scripts to verify the output. When those succeed, we will proceed with the performance test script which ramps up users at a rate of 10 per minute until we reach the target number of concurrent users. This load will then be maintained for 2 hours
    1. [ ] The performance test system will cost $240,000 which will include the hardware and setup. This system will allow us to create a test system that is representative of the production system and will allow us to simulate production-like conditions
    1. [ ] Because the cost of a performance test system is prohibitive, we will conduct the performance testing in the production environment using live data
    1. [ ] The product risks include data contention issues, data access issues, locking issues that will reject concurrent requests, network bandwidth constraints, data seek errors, data seek slowdowns or bottlenecks, and difficulty for the user in processing the returned data

1. ### You are working on a project that tracks health history information for patients across a region. The number of records handled by the system is in the millions due to the large number of patients in the region. Patient information must be accessible to doctors in offices, hospitals, and urgent care facilities. The information should be presented to the requestor within three seconds of request, particularly for patients with critical allergies and preconditions.
    You have been asked to prepare a presentation for the technical stakeholders regarding your plan for performance testing. Which of the following is an example set of information that should be shared with these stakeholders?
   1. [ ] Once configured, the performance test system will require data loading. Once loaded, we will next proceed to running a small set of sample scripts to verify the output. When those succeed, we will proceed with the performance test script which ramps up users at a rate of 10 per minute until we reach the target number of concurrent users. This load will then be maintained for 2 hours
   1. [ ] The performance test system will cost $240,000 which will include the hardware and setup. This system will allow us to create a test system that is representative of the production system and will allow us to simulate production-like conditions
   1. [ ] Because the cost of a performance test system is prohibitive, we will conduct the performance testing in the production environment using live data 
   1. [ ] The product risks include data contention issues, data access issues, locking issues that will reject concurrent requests, network bandwidth constraints, data seek errors, data seek slowdowns or bottlenecks, and difficulty for the user in processing the returned data

1. ### If your performance test is testing the speed of the response of a web service, which protocol is being used?
   1. [ ] ODBC
   1. [ ] HTTP
   1. [ ] REST
   1. [ ] SMTP

1. ### If your performance test is testing the speed with which database requests are sent and received, which protocol is being used?
   1. [ ] ODBC
   1. [ ] HTTP
   1. [ ] REST
   1. [ ] SMTP

1. ### If you are testing from the UI and you need to simulate the amount of time it will take a real user to read a prompt and enter data in a field, what should you implement in your test script?
   1. [ ] Wait time
   1. [ ] Think time
   1. [ ] Latency time
   1. [ ] Reading njtime

1. ### What is the value of nesting transactions for performance testing?
   1. [ ] It supports the concept of parent and child transactions
   1. [ ] It allows the tester to measure a series of discrete transactions
   1. [ ] It speeds the reporting time for the performance results
   1. [ ] It bypasses the network communication time by sending the transaction directly to the server that will process it

1. ### You are working on a project that tracks health history information for patients across a region. The number of records handled by the system is in the millions due to the large number of patients in the region. Patient information must be accessible to doctors in offices, hospitals, and urgent care facilities. The information should be presented to the requestor within three seconds of request, particularly for patients with critical allergies and preconditions.
    One of the operational profiles you have identified is an emergency room doctor. You have determined that this person will access the system 10 times per shift (a shift is 10 hours) and that they will normally view 6 patient records for each access. They will print those patient records to be retained in the patient’s file at the hospital. They will also enter notes into the database regarding the patient’s treatment. For new patients, another user will enter the information into the system.

    Given this information, what is missing to construct the operational profile for this user class?
   1. [ ] No interviews were conducted to better understand the user class
   1. [ ] The number of users across the system for this role is not known
   1. [ ] Batch processing of the patient upload information has not been considered
   1. [ ] Other system components that may be required (x-ray upload, lab results reporting) have not been considered

