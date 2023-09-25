# Long Term Goals & Tasks
* [ ] Targets Agreements
  * [ ] Gain the good knowledge and understanding of Microsoft Azure. Get certified.
    * [ ] AZ-900: Microsoft Azure Fundamentals Exam Prep - MAY 2021 [Udemy](https://www.udemy.com/course/az900-azure/learn/lecture/24303396#overview) 5h (14.99 eur|49)
    * [ ] Microsoft Azure Fundamentals (AZ-900) [PluralSight](    https://app.pluralsight.com/paths/skills/microsoft-azure-fundamentals-az-900) 10h
  * [ ] Gain the good understanding of the domain. Understand the principles of commodity trading, various terms, types of transactions, and so on. This will help be more independent in the day-to-day work activities. Take a course or lectures on this topic.
    * [ ] Oil & Gas : Markets Trading Pricing & Economic Framework (Udemy €89.99)
  * [ ] Retain or exceed team member average velocity
  * [ ] Attend a seminar/course about Agile and Lean. Propose and implement improvements in current Blackstar process. Make knowledge sharing presentation and present it to help others reach their goal of improving our IT processes and methodologies.
    * [x] Agile Organizations: DevOps & Agile (Percipio) [Started: 2021/10/20, Completed: 2021/10/20, Score: 100%]
    * [x] Agile Software Development: Agile Development Life Cycle [Started: 2021/10/21, Completed: 2021/10/21, Score: 100%]
# Shot Term Goals & Tasks
* [ ] Go to HR to pick up summer 2021 gift 

# Daily 
## 2021/10/26 Wednesday
* [ ] CORE-243 Make sure SSIS works with new config
  * [x] check how it worked on master, migration issues, check out earlier version
    * [x] handle migration issues, use vm-gva-sqld01 db's, cache etc
    * [x] the server side running the ssis needs to have approprite binaries 
    * [x] install DTSRuntimeWrap v12 to 64bit GAC, libary itself is not enough
      * [x] change expired privileged account password
  * [ ] may need to restore app.config and not use appsettings.area.json
### Other
* [x] Helped Petar with sql migration naming
* [x] Helped Yevhen with what to do if he fails to connec to Singapore preprod server
* [x] Helped Hui Ru with connection issues, but still unresolved 
* [x] Helped Antonio with loggin in as alternative user
* [x] Helped Antonio resolve user problems, his build, config issues, set up a physical deal and made sure he is nolonger suck

## 2021/10/26 Tuesday
* [ ] CORE-243 Make sure SSIS works with new config
  * [x] check how it worked on master, migration issues, check out earlier version
  * [ ] may need to restore app.config and not use appsettings.area.json
* [x] CORE-267 Improve message CompressedResult (on hold), story ready to dev
  * [x] Make notes to the JIRA story 
    * [x] ServerRequestLogger.RequestCompleted, 
    * [x] AppHost.OnAfterExecute Task.WaitAny extension method
  * [x] Add feedback to pull request  
### Other
* [x] Helped Octav with octopus, specifically where to set hotfix environment custom ICE passwords for CI
* [x] Asked dev chat about where/how to improve domain level skills
  > As I understand, we should casually improve our understanding in the domain of Oil & Gas by completing courses like Mennta: Oil Trading and Operations, Udemy: Oil & Gas: Markets Trading Pricing & Economic Framework and others.
  >
  > I remember that in August I was notified that earliest by the middle of October we will have a new learning site like Pluralsight and Udemy, where likely similar kinds of materials will be available. Was that site percipio or something else and has anyone started doing/looking for available courses?

## 2021/10/25 Monday
### Work
* [ ] CORE-243 Make sure SSIS works with new config
  * [x] Get latest CORE-29 and set up personal config from ConfigTemplates
  * [x] Stuck with logging in, https > http to local and change ports, make example for others
  * [x] Run ssis, has an issue
  * [ ] check how it worked on master, migration issues, check out earlier version
* [ ] CORE-267 Improve message CompressedResult (on hold)
  * [x] Have a talk with Oleg about the what was done
  * [ ] Make notes to the JIRA story 
    * [ ] ServerRequestLogger.RequestCompleted, 
    * [ ] AppHost.OnAfterExecute Task.WaitAny extension method
### Other
* [x] Filed a bug about archived outlook messages
* [x] Made sure CORE-29 builds on TC
* [x] Helped Yurii with xunit test execution order where db schema test had 

## 2021/10/22 Friday
### Other
* [x] Pair program with Antonio. Showed how to find last working commit and revert state.
* [x] Made sure CORE-29 builds locally
