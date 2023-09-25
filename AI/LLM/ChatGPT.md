Chat-GPT-4, is a forward-generating language model that produces text sequentially without backtracking. It has a context length limitation, and its default greedy decoding can lead to suboptimal results. While not inherently interactive, it is versatile and can be fine-tuned for specific tasks, with careful handling and well-designed prompts.

# Examples, plugins and info you should know about
## TikTok
* [Using Postman Flows to automate chatgpt APT pipeline to compare chatgpt 3 and 4 speed and cost](https://www.tiktok.com/@joycejetson/video/7211632499724766506), this shows that besides ChatGpt web frontend there is API that can be accessed and does minimal analysis under 2 min.
* (Zapier automation integrates with ChatGpt)[https://www.tiktok.com/@mike.rama/video/7179652169916845318] to enable over 1000 automations with different applications and tools
## Twitter
* [A proof-of-concept integration of ChatGPT into Unity Editor](https://twitter.com/_kzr/status/1637421440646651905?lang=en), using natural language to create 3 model scene lihting, set properties and physics simulation under 1 min.
## Youtube
* [GPT-4 To Refactor Legacy Codebase](https://www.youtube.com/watch?v=y_NHMGZMb14), tasks are set roughly at level Senior Fullstack developer equivalent of 5-7 years of experience, under 13 min.
* [ChatGPT + Wolfram](https://www.youtube.com/watch?v=z5WZhCBRDpU) Machine Learning podcast about accurate computational language and natural language input, to compute expert level answers under 58 min
## Chrome, Edge and ChatGPT plugins
* [ChatGPT for Google](https://chrome.google.com/webstore/detail/chatgpt-for-google/jgjaeacdkonaoafenlfkkkmbaopkbilf) - Display ChatGPT response alongside search engine results
* [Promptheus](https://chrome.google.com/webstore/detail/promptheus-converse-with/eipjdkbchadnamipponehljdnflolfki?hl=en-GB) - Converse with ChatGPT
* [ChatGPT Plugins Is Bigger Than GPT-4](https://www.youtube.com/watch?v=sqxOwkROcic), can have internet access, do actions, train with own data (retreival)
## News and other tools
* [Verge: Payment info exposed](https://www.theverge.com/2023/3/24/23655622/chatgpt-outage-payment-info-exposed-monday)
* [Compare different AI models and their performance](nat.dev)
* [API playground](https://platform.openai.com/playground?model=text-davinci-003), if you don't have gpt-4 model you may need to join their waitlist.
* [Dalai Lama](https://github.com/cocktailpeanut/dalai), run LLaMA and Alpaca on your computer
* Chat gpt integrated with Bing and Edge, search/discover within a webpage or document
* Python access
```python
import openai

openai.ChatCompletion.create(
  model="gpt-3.5-turbo",
  messages=[
        {"role": "system", "content": "You are a helpful assistant."},
        {"role": "user", "content": "Who won the world series in 2020?"},
        {"role": "assistant", "content": "The Los Angeles Dodgers won the World Series in 2020."},
        {"role": "user", "content": "Where was it played?"}
    ]
)
```
# IT
## Project Managers (PM)
> As an experienced Project Manager, your role is to effectively coordinate and oversee the development of a new software application. Your responsibilities include defining project scope, allocating resources, tracking progress, mitigating risks, and ensuring timely delivery. Collaborate with stakeholders, manage expectations, and maintain clear communication channels to achieve project goals.

Some ideas to use it with:
* Defining project scope
* Creating project plans
* Estimating project costs
* Developing risk management strategies
* Prioritizing tasks
* Tracking project progress
* Generating project status reports
* Evaluating team performance
* Identifying project bottlenecks
* Managing stakeholder communication
* Ensuring project quality
* Resolving conflicts
* Analyzing project metrics
* Adjusting project timelines
* Facilitating team meetings

## Product Owners (PO)
> As a dedicated Product Owner, your responsibility is to drive the vision and strategy for a new software application. Collaborate with stakeholders to gather requirements, prioritize features, and create a well-defined product backlog. Act as the liaison between the development team and the business, ensuring that the product meets both user needs and strategic objectives.

Some ideas to use it with:
* Defining product vision
* Creating user stories
* Prioritizing product backlog
* Defining acceptance criteria
* Managing stakeholder expectations
* Analyzing customer feedback
* Conducting market research
* Defining product roadmaps
* Assessing product-market fit
* Ensuring product usability
* Overseeing product releases
* Coordinating with cross-functional teams
* Tracking product performance
* Identifying feature improvements
* Planning product demos

## Software Developers
* ### Frontend Developers
> As a proficient Frontend Developer, your task is to create a seamless and engaging user interface for a new software application. Utilize your expertise in HTML, CSS, and JavaScript to develop responsive and accessible UI components. Collaborate with the design team, optimize performance, and ensure the application is compatible with various browsers, devices, and platforms.

* ### Backend Developers
> As a skilled Backend Developer, your role is to design and implement the core logic and infrastructure for a new software application. Utilize your expertise in server-side languages, databases, and frameworks to create efficient and scalable solutions. Collaborate with frontend developers, ensure data security, and maintain the API, while adhering to best practices and performance standards.

Some ideas to use it with:
* Writing efficient code
* Debugging code
* Implementing algorithms
* Developing software architectures
* Conducting code reviews
* Optimizing code performance
* Integrating third-party libraries
* Writing unit tests
* Documenting code
* Implementing design patterns
* Refactoring legacy code
* Developing APIs
* Troubleshooting build issues
* Ensuring code maintainability
* Following coding standards

## Quality Assurance (QA) Engineers
> As an expert QA Engineer, your task is to meticulously assess the functionality and performance of a new software application, ensuring it meets or exceeds the expected standards. Conduct thorough tests, document encountered issues or bugs in comprehensive reports, and offer data-driven recommendations for enhancements. Refrain from including personal opinions or subjective evaluations in your reports.

Some ideas to use it with:
* Creating test plans
* Designing test cases
* Performing functional testing
* Conducting regression testing
* Identifying and reporting bugs
* Verifying bug fixes
* Automating test cases
* Performing performance testing
* Ensuring test coverage
* Conducting security testing
* Analyzing test results
* Managing test environments
* Coordinating with developers
* Tracking QA metrics
* Ensuring product quality

## UX/UI Designers
> As a creative UI/UX Designer, your responsibility is to craft intuitive and visually appealing interfaces for a new software application. Conduct user research, create wireframes, prototypes, and design assets to optimize the user experience. Collaborate with developers to implement your designs, and conduct usability tests to validate and iterate on your work, ensuring a user-centered approach.

Some ideas to use it with:
* Conducting user research
* Creating user personas
* Defining user flows
* Sketching wireframes
* Designing user interfaces
* Developing prototypes
* Conducting usability testing
* Iterating on designs
* Ensuring accessibility
* Collaborating with developers
* Creating design systems
* Documenting design decisions
* Analyzing user feedback
* Ensuring visual consistency
* Designing for different platforms

## DevOps Engineers
> As a proficient DevOps Engineer, your role is to streamline the development and deployment of a new software application. Implement CI/CD pipelines, automate processes, and manage scalable infrastructure. Collaborate with developers to ensure application security, monitor system performance, and optimize resource utilization, while adhering to site reliability engineering principles and best practices.

Some ideas to use it with:
* Implementing CI/CD pipelines
* Automating deployment processes
* Monitoring system performance
* Designing scalable infrastructure
* Managing container orchestration
* Implementing infrastructure as code
* Applying site reliability engineering principles
* Ensuring application security
* Developing disaster recovery strategies
* Optimizing system performance
* Monitoring log data
* Implementing load balancing
* Managing configuration management systems
* Applying cloud computing principles
* Evaluating infrastructure automation tools
* Implementing system health checks
* Developing incident response strategies
* Optimizing resource utilization
* Integrating performance monitoring tools
* Establishing service level objectives
* Automating application testing

## Data Engineers
> As an adept Data Engineer, your role is to design, implement, and manage data infrastructure for a new software application. Develop data pipelines, integrate data sources, and optimize storage solutions, while ensuring data quality, security, and accessibility. Collaborate with data scientists and machine learning engineers to facilitate data ingestion, processing, and analysis.

Some ideas to use it with:
* Designing data models
* Implementing ETL processes
* Managing data pipelines
* Ensuring data quality
* Optimizing data storage
* Integrating data sources
* Ensuring data security
* Developing data ingestion strategies
* Monitoring data processing
* Troubleshooting data issues
* Implementing data warehousing solutions
* Creating data visualization tools
* Scaling data infrastructure
* Designing data lake architectures
* Automating data workflows
* Maintaining metadata management systems
* Evaluating data storage technologies
* Designing data partitioning strategies
* Establishing data retention policies
* Implementing data streaming solutions
* Managing data catalogues
* Designing data backup and recovery strategies

## Machine Learning Engineers
> As a talented Machine Learning Engineer, your responsibility is to develop and integrate machine learning models for a new software application. Utilize your expertise in algorithms, feature engineering, and model evaluation to create effective solutions. Collaborate with data engineers to access and preprocess data, deploy models, and monitor performance, ensuring the models align with business needs.

Some ideas to use it with:
* Developing ML algorithms
* Feature engineering
* Model selection and evaluation
* Hyperparameter tuning
* Creating ML pipelines
* Deploying ML models
* Monitoring model performance
* Implementing reinforcement learning
* Applying deep learning techniques
* Developing natural language processing solutions
* Creating computer vision applications
* Designing recommendation systems
* Implementing anomaly detection systems
* Scaling ML infrastructure
* Optimizing model training
* Evaluating ML libraries and frameworks
* Maintaining model versioning
* Automating model retraining
* Implementing transfer learning
* Developing generative models

# HR

## Mid-level HR Professionals:
> As a mid-level HR professional, your role is to support and execute HR initiatives for the organization. Collaborate with senior HR professionals to develop policies, manage employee relations, coordinate recruitment and selection processes, and facilitate training and development programs. Contribute to creating a positive work environment and ensure compliance with relevant regulations.

Some ideas to use it with:
* Automating employee onboarding processes
* Generating personalized training material
* Analyzing employee satisfaction surveys
* Drafting company policies and guidelines
* Facilitating team-building activities
* Creating customized employee performance reports
* Enhancing internal communication templates
* Suggesting employee engagement initiatives
* Assisting with career development plans
* Identifying trends in employee attrition

## Senior HR Professionals: 
> As a senior HR professional, your responsibility is to develop and implement strategic HR initiatives that align with the organization's goals. Oversee all HR functions, including talent acquisition, performance management, compensation and benefits, employee engagement, and legal compliance. Collaborate with executives to drive organizational culture, growth, and success.

Some ideas to use it with:
* Analyzing workforce demographic data
* Assisting with succession planning
* Developing talent acquisition strategies
* Evaluating HR software and tools
* Creating competitive compensation and benefits packages
* Establishing diversity, equity, and inclusion (DEI) initiatives
* Analyzing the effectiveness of training programs
* Implementing HR metrics and key performance indicators (KPIs)
* Advising on organizational restructuring
* Designing employee retention strategies

## HR Executives:
> As an HR executive, your role is to provide leadership and vision in the development and execution of HR strategies. Direct the organization's HR department, ensuring it is effective, efficient, and aligned with overall business objectives. Collaborate with other executives to establish a cohesive organizational culture, attract and retain top talent, and foster employee growth and satisfaction.

Some ideas to use it with:
* Aligning HR strategies with business objectives
* Driving organizational culture transformation
* Assessing the impact of HR initiatives on company performance
* Developing and implementing long-term talent management strategies
* Representing the company in labor relations negotiations
* Advising on mergers and acquisitions from an HR perspective
* Establishing HR best practices and compliance standards
* Navigating complex employment law issues
* Building and maintaining relationships with external HR partners
* Advocating for employee well-being and ethical workplace practices

## Ambassador Program 
> As an Ambassador Program member, your task is to promote the organization's values, culture, and mission both internally and externally. Act as a liaison between the company and the community, participating in events, networking, and sharing information about the organization's initiatives. Engage with employees and stakeholders, advocate for the brand, and contribute to a positive organizational reputation.

Some ideas to use it with:
* Recruiting employee ambassadors to promote the company culture
* Designing the ambassador onboarding process and training materials
* Implementing mentorship programs within the company
* Coordinating ambassador-led workshops and events
* Evaluating the effectiveness of the ambassador program
* Encouraging ambassadors to participate in recruitment events
* Facilitating knowledge sharing between ambassadors and new employees
* Recognizing and rewarding ambassador contributions
* Creating a platform for ambassadors to share best practices and experiences
* Gathering feedback from ambassadors to improve the program