

# Automation Testing
The Sample Exam Q&A Set originates from [https://www.istqb.org/certifications/test-automation-engineer] and is here for searchability and quotations to allow faster learning. Visit their site for the most up-to-date version.

Sample Exam set A | Version 1.1

1. ### Question #1 (1 point) Which of the following is considered to be an advantage of test automation over manual testing?
   1. [ ] The time required for test execution is lengthened and the coverage is increased
   1. [x] The time required for test execution is shortened and the coverage is increased
   1. [ ] The time required for test execution is lengthened and the coverage is reduced
   1. [ ] The time required for test execution is shortened and the coverage is reduced

    > #### Explanation / Rationale
    > 1. Is not correct
    > 1. Is correct. There is an expectation with good test automation that the time required for test execution will be reduced while the overall test coverage is increased
    > 1. Is not correct
    > 1. Is not correct

1. ### Question #2 (1 point) Which of the following is an important technical success factor for any significant automation project?
   1. [x] The TAA must be designed for learnability
   1. [ ] The TAA must support the ability to automate all manual tests
   1. [ ] The SUT must be self-documenting
   1. [ ] The GUI interaction and data must be coupled with the graphical interface

    > #### Explanation / Rationale
    > 1. Is correct. It must be designed for learnability, maintainability, and performance
    > 1. Is incorrect. Not all manual tests can or should be automated
    > 1. Is incorrect. The code could be self-documenting but the entire SUT would not be
    > 1. Is incorrect. Automation is easier with decoupling

1. ### Question #3 (3 points) You are deciding on the functional test automation approach for a highly complex system which is expected to be used in production for many years. You have already conducted a survey with the major tool vendors and you have determined that you will not be able to use any of their tools to create your test automation due to the non-standard interfaces that were required for the software. You and the developers have decided that your best automation approach will be through custom interfaces implemented specifically for testing.
     What are two concerns you should have with this approach?
   1. [x] If the interfaces are not disabled before release, there could be a security risk
   1. [ ] The performance of the test interfaces may be much faster than the performance of the real interfaces
   1. [ ]  The effort spent to develop test automation will not be justified by the expected lifespan of the code in production
   1. [x] Because there is a high level of intrusion, there may be false alarms generated
   1. [ ] Because there is a low level of intrusion, the test results will not be representative of the production code
    
    > #### Explanation / Rationale
    > 1. Is correct. A is noted in section 3.2.3 of the syllabus where it talks about checking for security risks if you leave test interfaces in place
    > 1. Is not correct. We are testing the code, not the performance
    > 1. Is not correct. It is stated in the question that this is a long-lived, complex product
    > 1. Is correct. Developing custom test interfaces is considered a high level of intrusion and this may generate false alarms due to the different code being exercised
    > 1. Is not correct. The custom interfaces introduce a high level of intrusion

1. ### Question #4 (3 points) You have been automating a legacy application that provides critical functionality to the business. An update to the legacy system has been approved and the developers plan to use third party software to provide the new functionality. The third party software has already been tested but the interface between the existing software and the new software is problematic. Your existing test automation needs to be extended to test the interface between these two products.
     How should you approach implementing the best automation solution?
   1. [ ] Develop test automation for the entire system including the legacy and third party applications
   1. [x] Investigate if automation is possible via the APIs used to interface with the third party software
   1. [ ] Develop new automation to test via the GUI of the third party software
   1. [ ] Investigate if automation can be implemented using the CLI to replace the existing GUI automation

   > #### Explanation / Rationale
   > 1. Is not correct. There is no reason to fully automate the testing of the third party system
   > 1. Is correct. If APIs are available automation at the API, level makes sense
   > 1. Is not correct. We are not testing the GUI of the third party software
   > 1. Is not correct. This is not a logical approach

1. ### Question #5 (3 points) You are evaluating functional test automation tools. The tool that you prefer can provide your organization with a favorable cost-benefit ratio, which appeals to senior management. Additionally, you feel the tool is superior in meeting your other technical criteria. However, the tool has many features most of which will never be used. As a result, you feel this makes the tool overly complex and confusing.
     What should your next steps be regarding selection of this tool?
   1. [ ] Consider another tool that is more user friendly
   1. [x] Explore the possibility of configuring the tool to turn off unnecessary features
   1. [ ] Plan to supplement selection of this tool with lengthy and comprehensive training sessions
   1. [ ] Consider acquiring an additional tool that can provide a more user friendly interface to the preferred tool

   > #### Explanation / Rationale
   > 1. Is not correct. The preferred tool meets your criteria, finding another tool may be difficult
   > 1. Is correct. Tools are often configurable and allow functionality to be hidden
   > 1. Is not correct. Training sessions take away from testing time and the need for training would continue for the life of the tool, which would be an expensive alternative
   > 1. Is not correct. Additional tool costs, configuration, and maintenance would make this an unacceptable alternative


1. ### Question #6 (1 point) When a system is designed for testability, one of the characteristics is that the test cases can access interfaces into the system that can be used to verify the expected behavior actually occurred as a result of the test.
     What is this characteristic called?
   1. [x] Observability
   1. [ ] Controllability
   1. [ ] Maintainability
   1. [ ] Interoperability

   > #### Explanation / Rationale
   > 1. Is correct. A system that allows visibility to the results of a test has the property of observability
   > 1. Is not correct. Because controllability is the ability of the interface to control behavior of the system
   > 1. Is not correct. Because they are quality characteristics rather than specific testability characteristics
   > 1. Is not correct. Because they are quality characteristics rather than specific testability characteristics

1. ### Question #7 (1 point) Which of the following is an important testability consideration when designing a SUT?
   1. [ ] Interoperability
   1. [x] Controllability
   1. [ ] Maintainability
   1. [ ] Transportability

   > #### Explanation / Rationale
   > 1. Is not correct. They are quality characteristics that will not necessarily influence testability
   > 1. Is not correct. They are quality characteristics that will not necessarily influence testability
   > 1. Is correct. This is necessary because it provides accessible interfaces
   > 1. Is not correct. This is not a legitimate term

1. ### Question #8 (1 point) What layer of the gTAA structure provides tool support for designing manual test cases and creating automated test cases?
   1. [ ] Test Adaptation Layer
   1. [ ] Test Definition Layer
   1. [x] Test Generation Layer
   1. [ ] Test Flexibility Layer

   > #### Explanation / Rationale
   > 1. Is not correct. It provides the interface between the test automation and the SUT
   > 1. Is not correct. It may specify test cases but does not generate test cases
   > 1. Is correct. It supports generating test cases from models of the SUT and manual test case design
   > 1. Is not correct. This is not part of the gTAA structure

1. ### Question #9 (3 points) You are working on the design of a test automation project. The gTAA was set up by a consulting company prior to your being hired. You are now looking to create the TAA from the gTAA.

    You have the following requirements that must be addressed by your TAA:
    1. The TAA must support independence across technologies. It is likely that this same test suite will be used in different test environments and on different target technologies
    2. The test artifacts need to be portable
    3. Vendor-neutrality is preferable
    4. It is vitally important that the TAA be maintainable and maintenance costs be minimized
    5. It is preferred that less technical people be able to maintain the system even though highly technical people have built it
    6. There is a large project budget for this effort for the next two years, but the budget will decrease after that time 
    
    Given these requirements, which one of the following should the TAE consider during the implementation of the TAA?
   1. [ ] The communication protocols used by the TAS to interact with the SUT
   1. [ ] The number of automated test cases to be maintained by the system
   1. [ ] The test roles that will be supported by the implementation
   1. [x] The use of abstraction in the implementation

   > #### Explanation / Rationale
   > 1. Is not correct. While these are certainly considerations for the implementation of the TAA, they will not help address the stated goals
   > 1. Is not correct. While these are certainly considerations for the implementation of the TAA, they will not help address the stated goals
   > 1. Is not correct. While these are certainly considerations for the implementation of the TAA, they will not help address the stated goals
   > 1. Is correct. Abstraction will likely be needed to accomplish the stated goals

1. ### Question #10 (1 point) Why is it important for the TAA to separate the test definition from the test execution?
   1. [ ] Separating the two increases the speed of execution
   1. [x] The test definition can be completed without knowledge of the tool that will be used for execution
   1. [ ] The execution will be able to add test cases to the test definition as needed during execution
   1. [ ] The test definition layer will supply the adaptation necessary for the tests to run with various tools and interfaces

   > #### Explanation / Rationale
   > 1. Is not correct. Separating the two does not have anything to do with
speed of execution
   > 1. Is correct. By separating the definition from the execution, the definition is immune from the tool selection and usage. If another tool is used, the definition does not have to change – only the execution layer will change. See section 3.1.1
   > 1. Is not correct. Test cases are not added during execution
   > 1. Is not correct. Adaptation is supplied by the adaptation layer

1. ### Question #11 (1 point) When designing the test adaptation layer, which of the following should occur?
   1. [ ] Selecting the interpretation or compilation approach for the test procedures
   1. [ ] Selecting data-driven, keyword-driven, pattern-based or model-driven test definition
   1. [ ] Selecting manual or automated test generation
   1. [x] Selecting tools that will be used to stimulate and observe test interfaces

   > #### Explanation / Rationale
   > 1. Is not correct. This should be selected at the test execution layer
   > 1. Is not correct. This should be selected at the test definition layer
   > 1. Is not correct. This should be selected at the test generation layer
   > 1. Is correct. This is one of the considerations for the test adaptation layer

1. ### Question #12 (1 point) When is the best time, for test automation, to consider legal and/or standards requirements of an SUT?
   1. [ ] When developing a TAS
   1. [ ] When implementing the SUT
   1. [x] When designing a TAA
   1. [ ] When creating a TAF

   > #### Explanation / Rationale
   > 1. A Is not correct. Consideration for standards and legal settings should have occurred before this time
   > 1. B Is not correct. Consideration for standards and legal settings should have occurred before this time
   > 1. Is correct. SUT standards and legal settings should be considered and any design requirements understood when designing the TAA
   > 1. D Is not correct. Consideration for standards and legal settings should have occurred before this time

1. ### Question #13 (3 points) You are working on a test automation project that will automate business scenarios for the user acceptance testers to use when conducting UAT. 
    The business scenarios are well-defined andfrequently repeated during UAT. The goal is to also be able to test these same scenarios as part of regression testing by executing the test automation. Structured scripting has already been used to develop the library of functions that can be used by the test automation.

    What scripting technique should be used to build upon the structured scripting that has already been done and to implement this test automation to meet the business goals?
   1. [ ] Scenario-driven scripting
   1. [ ] Keyword-driven scripting
   1. [x] Process-driven scripting
   1. [ ] Linear scripting

   > #### Explanation / Rationale
   > 1. Is not correct. This is not a real scripting type
   > 1. Is not correct. This could feed into the process-driven scripting
   > 1. Is correct. This will allow building on the structured scripting that has already been done and the libraries that have been created while automating the business processes
   > 1. Is not correct. It is referring to a more basic type of scripting and it has already been specified that structured scripting have been done

1. ### Question #14 (3 points) Your manager has requested you develop test automation to be used for a legacy system that is going to go through a series of infrastructure migrations. 

    The scripts will be used to verify basic functionality during these infrastructure changes. You need a solution that is simple and fast.

    Maintainability of the scripts is not a consideration because no changes to the software are anticipated. Which of the following is the best scripting approach in this situation?
   1. [ ] Structured scripting
   1. [ ] Data-driven scripting
   1. [ ] Keyword-driven scripting
   1. [x] Linear scripting

   > #### Explanation / Rationale
   > 1. Is not correct. These are more complex techniques that would result in more sustainable code but the additional cost and complexity are not justified for this project
   > 1. Is not correct. These are more complex techniques that would result in more sustainable code but the additional cost and complexity are not justified for this project
   > 1. Is not correct. These are more complex techniques that would result in more sustainable code but the additional cost and complexity are not justified for this project
   > 1. Is correct. Little prep work is required and the maintenance concerns are not an issue for this project

1. ### Question #15 (2 points) You are using a gTAA to create a TAS for a project. You have reviewed the project and determined that the test automation should be focused at the command line level rather than the user interface level due to the rapid and continual changes occurring in the user interface. The command line interface allows you to access all the functionality and will be a part of the released project. Given this information, what part of the standard gTAA can you leave out of the TAS?
   1. [ ] The test data component of the test definition layer
   1. [x] The GUI component of the test adaptation layer
   1. [ ] The test model component of the test generation layer
   1. [ ] The user interface component of the test execution layer

   > #### Explanation / Rationale
   > 1. Is not correct. You are still likely to need test data for your tests
   > 1. Is correct
   > 1. Is not correct. There is nothing in the question that indicates this is not needed
   > 1. Is not correct. It is not a component of the test execution layer

1. ### Question #16 (2 points) You are implementing a TAS from a TAA. The SUT communicates with another system, which is stable and available for use during testing. The test interface will be through the GUI. Given this information what component of the TAA can you exclude from the TAS?
   1. [ ] The test generation layer
   1. [x] The simulator within the test adaption layer
   1. [ ] Test execution within the test execution layer
   1. [ ] The GUI from the test adaptation layer

   > #### Explanation / Rationale
   > 1. Is not correct. Because these components are still needed to create the TAS
   > 1. Is correct. A simulator is not needed because you can communicate directly with the external system
   > 1. Is not correct. Because these components are still needed to create the TAS
   > 1. Is not correct. Because these components are still needed to create the TAS

1. ### Question #17 (1 point) Which of the following is true about reuse?
   1. [x] Reuse is built into the TAA and maintained and improved in the TAS
   1. [ ] Reuse is built in both the TAA and TAS and maintained in the gTAA
   1. [ ] Reuse is only applicable for the gTAA
   1. [ ] Reuse is built into the TAS and maintained and improved in the TAA

   > #### Explanation / Rationale
   > 1. Is correct. Per the syllabus the TAA must designed for reuse but the TAS can increase the ability for reuse
   > 1. Is not correct. Only A contains the proper wording per the syllabus
   > 1. Is not correct. Only A contains the proper wording per the syllabus
   > 1. Is not correct. Only A contains the proper wording per the syllabus

1. ### Question #18 (2 points) Senior management wants to implement test automation into your organization and has asked you to lead this initiative. The organization has a number of systems of varying criticality, some of which may benefit from automation once a TAA is mature. You have been given direction to start with a pilot.

    How do you select a suitable project for the TAS?
   1. [ ] A high visibility project in order to highlight the success of the pilot
   1. [x] A non-critical project in order to mitigate any delays the TAS may cause
   1. [ ] A project that is simple and easy to automate
   1. [ ] A new project that is immature and still in 
   
   > #### Explanation / Rationale
   > 1. Is not correct. This may result in great risk to the automation project if it fails
   > 1. Is correct. The pilot should have minimal impact upon normal business but should be conducted with a realistic project
   > 1. Is not correct. A trivial project will be of little benefit
   > 1. Is not correct. New projects are not good candidates for automation

1. ### Question #19 (2 points) You have been asked to conduct a pilot for the test automation tool. You have identified a suitable target project (average size and cost), planned the pilot (treating it as a development effort), and conducted the pilot.

    What should be your next step?
   1. [ ] Conduct another pilot on a critical project to ensure the tool will work when it really matters
   1. [ ] Conduct another pilot on a trivial project to ensure the time requirements will not be too
high on small projects
   1. [x] Evaluate the results engaging the stakeholders to gather their viewpoints
   1. [ ] Evaluate the results within the pilot testing team and prepare a report for management

   > #### Explanation / Rationale
   > 1. Is not correct. Critical or trivial projects should not be used for a pilot
   > 1. Is not correct. Critical or trivial projects should not be used for a pilot
   > 1. Is correct. It is important to gather input from the stakeholders before moving forward
   > 1. Is not correct. This will occur, but the management report should not be prepared until there is feedback from the stakeholders

1. ### Question #20 (3 points) Your team has been working on creating a strong and maintainable TAS. The TAS is expected to be used for at least five years, so good maintainability is critical.

    The team has done the following:
    1. Created an impact analysis process for all proposed changes to the system
    2. Documented the usage for the TAS
    3. Documented the third party dependencies, including contacts within the third party
    organization
    4. Verified that the TAS runs in an environment separate from the SUT environment

    Given this information, what is a major factor of maintainability that has not been addressed?
   1. [x] The TAS must be modular, so key components can be replaced as needed
   1. [ ] The TAS must be a copy of the gTAA
   1. [ ] The SUT must reside in the same environment as the TAS
   1. [ ] The TAS must unite the test scripts with the TAF
   
   > #### Explanation / Rationale
   > 1. Is correct. The TAS must be modular for maintainability
   > 1. Is not correct. The TAS is an instantiation of the gTAA
   > 1. Is not correct. The two must reside in separate environments
   > 1. Is not correct. The TAS must separate the scripts from the TAF

1. ### Question #21 (3 points) You have just updated your TAS to include new features.
    
    What steps should you take to ensure that the changes have not adversely affected any existing 
functionality?
   1. [x] Compare the new and old TAS versions and assess the impact of any differences
   1. [ ] Statically check to ensure procedures for the new and old TAS versions are identical
   1. [ ] Ensure the same stubs and drivers are used in the new TAS
   1. [ ] Use SUT release notes as a way to ensure the new TAS will operate correctly
   
   > #### Explanation / Rationale
   > 1. Is correct. The TAS is like any other software and changes must be assessed to mitigate risk
   > 1. Is not correct. Procedures will change as the TAS changes
   > 1. Is not correct. Stubs and drivers should not be present in an active TAS
   > 1. Is not correct. System release notes of the SUT may have nothing to do with identifying vulnerabilities in the TAS

1. ### Question #22 (1 point) Why is it important to have standard naming conventions for a TAS?
   1. [ ] A TAS that uses standard names will enable faster execution of the test automation
   1. [x] A TAS that uses standard names will be easier for a new person to learn
   1. [ ] A TAS that uses standard names will support global substitutions when test automation 
standards change
   1. [ ] A TAS that uses standard names will allow separation of the test scripts from the TAF
   
   > #### Explanation / Rationale
   > 1. Is not correct. Using a standard naming convention will not affect any of these areas
   > 1. Is correct. Standard names will be easier for a new person to learn and will make the code easier to understand
   > 1. Is not correct. Using a standard naming convention will not affect any of these areas
   > 1. Is not correct. Using a standard naming convention will not affect any of these areas

1. ### Question #23 (2 points) Your manager is concerned that it will be difficult to assess the success of the test automation implementation unless it is possible to show that the quality of the tested software steadily improves. You have explained that pass/fail numbers are reported at the end of each execution, but your manager wants to see this information provided automatically to a dashboard that will allow drilling down to the details.

    How can you automatically provide this information from the test automation software?
   1. [ ] You cannot. This information will have to be gathered manually at the end of each execution
   1. [x] The automated testware can be used to report this information to a database and a 
dashboard can be created from the data in the database that will show the trends in passed/failed test cases
   1. [ ] The automated testware can report each set of test execution results to a spreadsheet that can be published showing the detailed results
   1. [ ] The TAE can record the information during execution and report that into a graphing tool that can be provided for management reporting
   
   > #### Explanation / Rationale
   > 1. Is not correct. You can provide this information
   > 1. Is correct. This is an automated solution that will utilize the tools to provide accurate current and trend information
   > 1. Is not correct. It will provide only current execution information but no overall trending
   > 1. Is not correct. It is a manual process not an automated solution

1. ### Question #24 (2 points) You normally start execution of an automated regression test suite at the end of the workday, as it  is a lengthy test. Occasionally the test does not complete by the start of the next workday even though it should complete within five hours of starting.

    What is the most efficient approach you could take to determine the cause of the problem?
   1. [ ] Run the test at the beginning of the day and monitor it manually
   1. [ ] Evaluate a vendor reporting tool that measures test progress
   1. [ ] Supplement your staff with a night shift to monitor the test while it is running
   1. [x] Automate collection of the test execution results
   
   > #### Explanation / Rationale
   > 1. Is not correct. It interferes with other planned activities
   > 1. Is not correct. This is an unnecessary cost
   > 1. Is not correct. It is not practical
   > 1. Is correct. Automated collection is inexpensive and effective

1. ### Question #25 (1 point) When implementing results reporting for test automation, what is a good way to allow the reader to  make a quick assessment of the progress of the test execution?
   1. [ ] Spreadsheets
   1. [x] Traffic lights
   1. [ ] Detailed reports with percentages of completion
   1. [ ] Database of results
   
    > #### Explanation / Rationale
    > 1. Is not correct. These will not allow quick analysis
    > 1. Is correct. Using colors, such as traffic lights, to indicate progress is mentioned in the syllabus
    > 1. Is not correct. These will not allow quick analysis
    > 1. Is not correct. The data would still have to be derived from the database before it could be analyzed

1. ### Question #26 (1 point) You have been asked to distribute the results of your test automation daily. The preferred method for distribution of these results is via e-mail.

    What is an important characteristic of your test automation reporting that will allow you to provide this information?
   1. [x] It should integrate with a common third party tool
   1. [ ] It should allow you to supplement the results with manual commentary
   1. [ ] It should provide a way to publish the test log library
   1. [ ] It should allow you to capture an audio message to accompany test results
   
   > #### Explanation / Rationale
   > 1. Is not correct. The timing information is probably not pertinent and the SUT information is also probably not relevant to the problem although, if it is, it is likely it will be seen when the data in 1, 4, 5 is analyzed
   > 1. Is not correct. The timing information is probably not pertinent and the SUT information is also probably not relevant to the problem although, if it is, it is likely it will be seen when the data in 1, 4, 5 is analyzed
   > 1. Is not correct. The timing information is probably not pertinent and the SUT information is also probably not relevant to the problem although, if it is, it is likely it will be seen when the data in 1, 4, 5 is analyzed
   > 1. Is correct. This would be the most useful information. This is going to be a multi-step analysis starting with the first failure (which is probably at the step rather than test cases level) then replaying it to see what is actually happening and then looking at all the details of the failure

1. ### Question #27 (3 points) You have been working with a test automation suite that provides good test coverage. The suite contains 500 scripts and has previously run without any problems. Recently, a number of the tests late in the test run have been failing. You have done some analysis and it appears that the test  failures are being caused by a SUT failure that is not being detected by one or more tests earlier in the test run. You need more information to pinpoint the test or tests with a false-negative result.

    Consider the following options: 
    1. The status of execution for each test case (pass/fail)
    2. Timing information for each step in each test case
    3. Dynamic information about the SUT
    4. All actions of each test case to allow replaying each test
    5. Failure information for any step in a test case that encounters an error

    What type of logging do you need in order to complete your analysis and get the information to help identify the problem?
   1. [ ] 1, 2, 3
   1. [ ] 2, 4, 5
   1. [ ] 2, 3, 5
   1. [x] 1, 4, 5
   
   > #### Explanation / Rationale
   > 1. Is not correct. This is too specific
   > 1. Is correct. The test environment information is important in determining test coverage and test validity
   > 1. Is not correct. This information may be derived from the report, but is not a key attribute
   > 1. Is not correct. This level of detail would be in the defect report and not in a test execution report

1. ### Question #28 (1 point) When publishing a test execution report which key attribute must the report contain?
   1. [ ] Test case steps
   1. [x] Test environment
   1. [ ] Assessment of the reliability of the SUT
   1. [ ] Root cause of any failures
   
   > #### Explanation / Rationale
   > 1. Is not correct. This is too specific
   > 1. Is correct. The test environment information is important in determining test coverage and test validity
   > 1. Is not correct. This information may be derived from the report, but is not a key attribute
   > 1. Is not correct. This level of detail would be in the defect report and not in a test execution report

1. ### Question #29 (2 points) You have been asked to implement test automation for a system that has been in production for  two years. The software is relatively stable, updates are made once a quarter, and the quality of the software is extremely important. 

    The organization follows a V-model lifecycle and has used this model for many years. Software quality is good on the quarterly releases, but there is concern that the time required for the regression testing is not cost effective and is inhibiting the flow of new features. You see several challenges in this implementation, the greatest of which is the creation and preservation of test data. While the test environments are stable and controlled, the test data is frequently refreshed from production, which makes it difficult to write maintainable test automation.

    Given this information, which of the following is most likely to be a problem for this test automation effort?
   1. [ ] Maturity of the test process
   1. [ ] Suitability of automation for the stage of the software product lifecycle
   1. [ ] Frequency of use
   1. [x] Complexity to automate
   
   > #### Explanation / Rationale
   > 1. Is not correct. They follow a mature process
   > 1. Is not correct. This is a good time to automate because the software is stable and the updates are made quarterly
   > 1. Is not correct. The software will be used frequently and for a long time
   > 1. Is correct. Because dealing with the data issue adds a level of complexity to the test automation. It is likely that it will need to create and maintain its own data and preserve this data across the production refreshes

1. ### Question #30 (1 point) What is the most common basis for an automated test script?
   1. [ ] The gTAA
   1. [ ] The SUT
   1. [x] A manual test case
   1. [ ] The functional requirements
   
   > #### Explanation / Rationale
   > 1. Is not correct. These would not provide the basis for a test script
   > 1. Is not correct. These would not provide the basis for a test script
   > 1. Is correct. Automated test scripts are commonly written from manual test cases
   > 1. Is not correct. While it may provide the basis for the testing, it is not usually the basis for an automated test script

1. ### Question #31 (1 point) What is a stated goal for automated regression test coverage if it is to ascertain the overall quality of the SUT?
   1. [ ] Cursory
   1. [ ] Broad
   1. [ ] Deep
   1. [x] Broad and deep
   
   > #### Explanation / Rationale
   > 1. Is not correct. This will not give an indication of overall quality
   > 1. Is not correct. Both broad and deep are needed
   > 1. Is not correct. Both broad and deep are needed
   > 1. Is correct. Per the syllabus

1. ### Question #32 (1 point) Who should provide feedback to the TAE when implementing new features to an existing TAS?
   1. [ ] Business Analysts
   1. [ ] Senior Managers
   1. [x] Test Designers with domain expertise
   1. [ ] System Administrators
   
   > #### Explanation / Rationale
   > 1. Is not correct. They are not versed in the specific TAS design
   > 1. Is not correct. They are not versed in the specific TAS design
   > 1. Is correct. Test designers with domain expertise must ensure the TAS will work with the new features
   > 1. Is not correct. They are not versed in the specific TAS design

1. ### Question #33 (1 point) Which of the following is the best reason for automating the confirmation testing of a defect?
   1. [ ] To close a gap in the existing automation
   1. [x] To ensure that the fix works and continues to work
   1. [ ] To justify the time spent finding the defect
   1. [ ] To test the configuration management processes
   
   > #### Explanation / Rationale
   > 1. Is not correct. While there may be gaps in the test automation this is not the primary reason to automate confirmation testing
   > 1. Is correct. You are trying to be sure the fix works and make sure that the fix does not break later or get lost because of a configuration management problem
   > 1. Is not correct. The time spent finding the defect should have been justified by the severity of the defect
   > 1. Is correct. You are trying to be sure the fix works and make sure that the fix does not break later or get lost because of a configuration management problem
   > 1. Is not correct. This is a side effect and, while it does not test all the configuration management processes, it does make sure that the fix isn’t lost for some reason

1. ### Question #34 (2 points) You are having problems with the reliability of the automated test environment and setup. You have decided to create a test suite you can execute to verify the environment before you run the actual test scripts.

    Which of the following would provide the best quick test of the environment?
   1. [ ] Run a set of tests that are known to pass and verify that they still pass
   1. [ ] Run a set of tests that are known to fail and verify that they still fail
   1. [x] Run a set of tests containing both passes and fails and verify that the results are consistent
   1. [ ] Run the entire set of automated tests and verify the results because a subset will not be representative
   
   > #### Explanation / Rationale
   > 1. Is not correct. This would be limited in scope and would not provide sufficient coverage
   > 1. Is not correct. This would be limited in scope and would not provide sufficient coverage
   > 1. Is correct. This is the best option assuming you have picked a good set of tests. You want to test that good tests pass and failed tests fail
   > 1. Is not correct. You are looking for a quick test

1. ### Question #35 (2 points) You are testing a system that is updated by monthly service packs. You are testing multiple versions of the SUT simultaneously. Your TAS is complex and you need to ensure it remains consistent across the different SUT environments.

    How will you ensure that the same version of the TAS is used to test each SUT?
   1. [ ] Update the TAS each time the SUT is patched
   1. [ ] Revert back to manual testing
   1. [x] Install the TAS into the SUT environments from a central repository
   1. [ ] Develop a tool to track historical test results
   
   > #### Explanation / Rationale
   > 1. Is not correct. This is not feasible
   > 1. Is not correct. Reverting to manual testing is not warranted
   > 1. Is correct; downloading a copy from a repository ensures a consistent TAS
   > 1. Is not correct. Historical data tracking will only illustrate the symptom of inconsistent results

1. ### Question #36 (2 points) You have executed an automated test suite for a product that was released to production. Although your tests passed, there was a major failure in production in an area that is well covered by your automated tests. You have verified that your tests did pass and that the reporting of the results was correct.

    What should you do now to verify the validity of your tests?
   1. [ ] Run tests that should fail and verify that they fail
   1. [ ] Run tests that should pass and verify that they pass
   1. [x] Check that the post conditions of each test case are being verified correctly
   1. [ ] Change your test data and run the tests again
   
   > #### Explanation / Rationale
   > 1. Is not correct. They will not show any problems because the test results were all good when you ran the suite
   > 1. Is not correct. They will not show any problems because the test results were all good when you ran the suite
   > 1. Is correct. Given this information, the post conditions are not being checked correctly so test cases are being marked as passed even though something did not work correctly
   > 1. Is not correct. This is unlikely to change anything

1. ### Question #37 (2 points) You are preparing to execute a test automation suite for a safety critical healthcare application. Which approach should you take to verify the accuracy of the test results?
   1. [x] Execute test cases with known failures and verify that they continue to fail
   1. [ ] Extract data from the production system and verify compatibility with the TAS
   1. [ ] Examine historical test trends on a similar SUT
   1. [ ] Execute the test suite slowly and methodically
   
   > #### Explanation / Rationale
   > 1. Is correct. This is a recognized way to test automation suite
   > 1. Is not correct. Test data should already have been used to validate the TAS
   > 1. Is not correct. Historical test trends will not be useful in verifying the actual test results
   > 1. Is not correct. The speed of execution should not affect the accuracy of the testing results

1. ### Question #38 (3 points) You have been reviewing the test cases in your TAS and have discovered that there is a wide variety of methods the TAEs have used to handle system errors. How should you handle this?
   1. [x] Establish an error recovery process in the TAS and ensure all test cases are using that 
process
   1. [ ] Create a library of recovery processes so there is better reuse between the different scripts
   1. [ ] Move to a keyword-driven approach and make recovery one of the keywords
   1. [ ] Provide better wait time handling in the scripts to avoid system errors
   
   > #### Explanation / Rationale
   > 1. Is correct. Per the syllabus this is a best practice
   > 1. Is not correct. These are still going to be duplicating processes, potentially
   > 1. Is not correct. These are still going to be duplicating processes, potentially
   > 1. Is not correct. There is no indication that the problem is due to better wait time

1. ### Question #39 (3 points) Up until now you have provided automated testing for a stable SUT. Because of changing business demands, the SUT will be updated to include several new features and plug-ins that communicate via APIs.

    In what way should you update the TAS?
   1. [ ] Improve TAS recovery to make it more fault-tolerant when API calls fail
   1. [ ] Update the documentation for the TAS including its support for APIs
   1. [ ] Improve the logging to capture the anticipated increase in defects due to API failures
   1. [x] Modify the adaptation layer in the TAA to enable the TAS to test via the APIs
   
   > #### Explanation / Rationale
   > 1. Is not correct. These do not directly enhance the API testing capabilities of the TAS
   > 1. Is not correct. These do not directly enhance the API testing capabilities of the TAS
   > 1. Is not correct. These do not directly enhance the API testing capabilities of the TAS
   > 1. Is correct. Modifying the adaptation layer to enable API testing will allow the TAS to access the plugins

1. ### Question #40 (3 points) You have been conducting a quality review for your TAS. You have discovered that it has not been updated for three years. The TAS functions properly and provides good coverage of the SUT; however, you want to ensure that it is working as efficiently as possible.

    What step should you consider in order to increase efficiency of the TAS?
   1. [ ] Ensure consistent naming standards for new automation code
   1. [ ] Make changes to the TAS in rapid succession to keep pace with leading edge practices
   1. [x] Ensure the latest libraries are incorporated into the TAS
   1. [ ] Enlist a third party vendor to evaluate the current TAS
   
   > #### Explanation / Rationale
   > 1. Is not correct. While this is a good practice, new automation code is not being written
   > 1. Is not correct. Speed of change to the TAS is risky and there is no indication that leading edge practices will be more efficient
   > 1. Is correct. Using the latest DLLs tends to improve efficiency and effectiveness
   > 1. Is not correct. It might help identify inconsistencies, as it is not cost effective