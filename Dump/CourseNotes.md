## Agile Software Development: Agile Development Life Cycle
Colin Calnan

Why DevOp's with Agile (bind QAs, BAs and IT support with Dev)
* Speed / Speedy deployment (microserces, continuous delivery)
* Rapid delivery (continuous integration/delivery)
* Reliability (continuous integration/delivery, logging)
* Scalability (automation/consistency) repeatable
    * reduces infrastucture cost
    * increases customer marcet
* Collaboration (combine workflows, ownership, accountability, shared responsibilities)
* Security (policies, controls, configuration management)
    * Automatic and repeatable processes
    * Early control development

Agile 
* Values
    * Individuals and interations > processes and tools
    * Working software > pomprehensive documentation
    * Customer collaboration > contract negotiation
    * Responding to change > following a plan
* Iteration
  1) Requirements
  2) Design
  3) Development
  4) Test
  5) Deploy (loop 1)
  6) Review
* Blackstar iteration
  1) ``BA`` extracts requirements from ``end-user``
  2) ``BA`` designs ``epic``, reviewed by subset ``QA``, ``DEV`` who split it into ``features`` / ``stories``
     * keep updating the features when specs change
     * update technical documentation
     * add required permission
     * add details how to test the story
  3-4) ``Dev`` develops
     * creates ``unit/integration tests``
     * develops ``feature`` locally
     * asks ``BA`` to update stories if mistakes or clearifications are found (or do it themselfs after approval is given and BA is busy)
     * creates feature branch with a story number ex: ``CORE-29`` and ``pull request`` where it is included in the title
       * add minimum of 2 ``reviewers``, where 1 must be ``area lead``. Approvals are needed and ``DEV``'s cannot complete ``pull request`` against ``main branches`` themselves.
     * quality gate
       * ``CI`` runs build, ``static analyzers``, ``unit`` and subset of ``integration tests``
       * ``devops server`` checks ``GIT merge conflicts`` against branch it is targeting to`, (and additional code analysis with code coverage)
     * ``BA``, ``QA`` can use ``CI`` to deploy pull request to pool of +40 ``hotfix environments`` and pick pick from predefines sets of area specific databases.
     * If feature requires ``BA``, validation then ``QA`` usually waits until that is done.
     * pull request is merged by area lead when reviewers issues are solved, tests pass
  5) ``CI`` does deploy (ex: prod > preprod > uat > master)
     * main branch deploys daily or when deploy is invoked. Shared chat is used to notify request about main branch deploys and people can say no in 3-5 min.
     * when changes do not go to master branch then CI automerges are set up to merge it to down. When automerges fail then ``support guy`` will fix it by doing manual merge
  5*) ``managers/t-com`` creates releases (ex: new uat or new preprod) 
     * before release the branch is frozen (no new commits are accepted) and new branch is created (in reality critical fixes can be made, and if UAT is frozen then changes from PREPROD and PROD still come)
     * automerge from frozen branch is redirected to new branch and it directs to next main branch. 
     * email/chat is notified when this is done and wiki is updated to show against what main branch environments are pointing to
  6) ``QA`` does rewiew
     * create new ``regression tests``
     * review existing ``regression testing`` before release (helped by ``it-support``)
     * solidated features are converted to ``automated tests``
     * there are separate ``CI``
  6*) ``BA``, subset ``end-user`` and ``it-support`` do their area specific manual tests before release
     
CI - Continuous Integration
* Benefits
  * Reduces/Eliminates manual tasks
  * Eliminates bottlenecks
  * Increases value-adding tasks
  * Better error resulution
* Activities
  * 1) Continuous exploration (loop 1)
  * 2)
