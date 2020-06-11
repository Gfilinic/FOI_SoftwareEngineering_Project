## PROJECT REVIEW

## Project documentation
Some images are not displaying correctly in your project documentation. Although I tried to find the images in your documentation folder, the review might be incomplete. Please check your wiki pages and fix issues with missing images.  
* DEVELOPMENT FRAMEWORK - Adapted waterfall model
* PROJECT PLAN - OK. It is creditable to have the plan adjusted with your chosen development framework.
* SALES PROPOSAL (OFFER) - Please create an official offer letter. It does not have to be as detailed as in this example (https://www.pandadoc.com/sales-proposal-template/) but the most important segments could fit on a single A4 page.  
The presented project documentation is placed on good track. Apart from above-mentioned possible improvements, please add a new subchapter on team members' responsibilities.  
  
## Technical documentation
In general, I like your approach to display technical documentation of each project member. However, for the sake and benefits for the project it is much better to join your inputs into a single document. Beneath the title of each section you can write the author (responsible team member) name.  
Unfortunately, the missing images are not showing in the section of Luka Mrkonjić and in this case it was much harder for me to search for the missing images in the documentation folder :(  
Clément’s section is not written yet. Clement please do your part asap.  
I like the approach and structure of documentation that was provided by Goran, Tomislav and Stjepan. In this phase I was not dealing with semantic correctness of the diagrams, instead I have put focus on syntactical correctness. The semantics will be checked during the oral defence of your project and the diagrams will be aligned with the code. Related to diagram syntax, Tomislav's use case diagrams are not defining use cases correctly. Additionally, Tomislav's activity diagram has the wrong use of a fork element. Did you mean to use exclusive decision instead? Finally, it would be better to support the diagrams with some (not extensive) text. So, the chapter should have the introduction, the glue-text related to diagrams, some explanations if necessary and concluding remarks. Similar mistakes are made by Stjepan as well. So, remember that use case diagram does not contain sequence or timely context which means that use case diagram does not answer the question which use case is before or after other use cases.  
Finally, the technical documentation should contain additional chapters on application architecture, on working with data and maybe on some other aspects which I am not seeing now.  


## Implementation
The source code versioning is your weakest point. It should be improved as soon as possible. Please do not add files via upload anymore. Each commit should be staged and commented. Please remember and observe the materials from our exercises on this section. Additionally, please use feature-branch workflow for your future commits. Check this out: https://www.atlassian.com/git/tutorials/comparing-workflows/feature-branch-workflow.  
In general, I am satisfied with the level of implementation of your app. However, you will have to put into the higher gear if you want to finish it during this exam term. Related to your source code please avoid message boxes and use on form elements (such as labels) to display relevant information to the user. The main form is hard on different screen resolutions so please make it more flexible. It could be achieved easily by docking or placing proper anchors on form elements.  
As there are different types of users in your app, please add a special chapter in your documentation on how to setup and test your app. The chapter should also include the information on already created test accounts (usernames and passwords).  
  
P.S. Did you really mean to name the class DataBaseL.cs?  
  
## Additional remarks
Please make your wiki's home page as the landing page of your documentation. You can reuse some data from your project applications form and from your project documentation to give brief intro to your project, its main features and architecture and intro to your team.  
  
Please do not forget to meet minimal project requirements before approaching the defence.  
  
From my point of view, your project is on good tracks. Maybe the implementation is behind the schedule, but I find myself as an accomplice. Sorry for that. Thus, let's push it a little harder together now and finish the project on time. If you will have any questions do not hesitate to contact me (and remind me if necessary).  

## Your score
F1: 13 points  

---

## General feedback
Good project idea. It is accepted with greetings. The few enhancements are described below in separated section. The proposed project fits in the course framework and when implemented the students will achieve the planned learning outcomes. Please read comments bellow and update your project idea accordingly. 

## Software architecture in relation to database
I kindly ask for your software architecture to be based on centralized database (access to which your already got from assistant Mijač). Thus, more than one app should be able to connect to the database at same time. This aspect, if applicable, should be taken into consideration when designing other feathers (e.g. when two users are ordering pizza with similar ingredients at the same time, but amount of resources of chosen ingredient is enough for only one pizza). 

## The improvements of the system
1. Please make your product for more than one potential buyer. This means that you should be able to sell this app to more than one pizzeria. Each buyer gets one super admin account which than handles everything for its pizzeria.
2. Please make your reports, bills and other document exportable to PDF.
3. Please ensure the possibility of sending the proper documents (e.g. bills) to e-mail of user. 
4. Please create the possibility of sending the user an email (or in app) notification that his pizza is ready and with planned delivery time.

Please update your proposal and define team member responsibilities as soon as possible. Please try to make every team member has the approximately the same amount of work.
