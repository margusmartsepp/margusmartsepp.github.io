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
