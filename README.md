# MyJournals
My Journals is a CRUD API that allows you to create unlimited number of journals within five categories to choose from.

Project Features
+ This is a CRUD API
+ Application is asynchronus
+ Created a dictionary/list, populated it with several values, retrieved at least one value, and used it in program.

JOURNAL CATEGORIES
1. Health Journal that can be used the record entries for tracking health information
2. Dietary Journal to help track your eating habits and meals.
3. Travel Journal so thar you can record your travels and cross country adventures! 
4. Personal Journal for normal everyday Journaling. Feel free to record your thoughts, dreams, etc!
5. Exercise Journal to keep track of your Workout Sessions.

+++Before starting the app be sure to run the following command:
  dotnet ef database update

TO RUN THIS API:
You will need to provide a unique ID for each of the payloads GUID. Go to (guidgenerator.com). This is a free online GUID generator.
For the "date", your local machine will automatically generate the current date or you can enter a custom date using the date format shown in each payload.

Create your own Payload on swagger or try these pre-made payloads:

DIETARY
  * "id": "Go to guidgenerator.com",
  * "date": "YYYY-MM-DD",
  * "notes": "Ready for my new diet! maximum 2100 calories a day. Here we go!",
  * "breakfast": "Apple Cinnamon Oatmeal with OJ",
  * "lunch": "Turkey Club Wrap with Apple Slices. Green Tea",
  * "dinner": "Filet Mignon, Sauteed Green Beans, Herb Roasted Potates, Diet Coke",
  * "desert": "Creme Brulee with Fresh Strawberries",
  * "snacks": "Trail Mix, Smart Water",
  * "totalCalories": 1750,
  * "totalCarbohydrates": 75,
  * "totalProtien": 55

EXERCISE
  * "id": "Go to guidgenerator.com",
  * "date": "YYYY-MM-DD",
  * "notes": "Don't forget to log steps and reps",
  * "workOutType": "Cardio 2-mile run",
  * "duration": "25 mins"

HEALTH
  * "id": "Go to guidgenerator.com",
  * "date": "YYYY-MM-DD",
  * "notes": "Having abdominal pain post surgery. have had multiple procedures. I need a resolution. Now!",
  * "healthIssue": "Abdominal pain",
  * "description": "Had a procedure to eliminate pain, pain started again in lower abdomen",
  * "physician": "Dr.Pepper"

JOURNAL
  * "id": "Go to guidgenerator.com",
  * "date": "YYYY-MM-DD",
  * "notes": "Lets get ready to Journal! This is just the begining. I cant wait to share my history and organize things that matter to me."

PERSONAL
  * "id": "Go to guidgenerator.com",
  * "date": "YYYY-MM-DD",
  * "notes": "I just started my new job as a software developer with SAMSUNG ELECTRONICS. I'm so glad its 100% remote. I can work anywhere in the world!",
  * "entryTitle": "Best Day Ever"

TRAVEL
  * "id": "Go to guidgenerator.com",
  * "date": "YYYY-MM-DD",
  * "notes": "I LOVE BEING A DIGITAL NOMAD!!",
  * "destination": "ONTARIO, CANADA",
  * "duration": "2 WEEKS"




