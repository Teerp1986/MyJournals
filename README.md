# MyJournals
My Journals is a CRUD API that allows you to create unlimited number of journals within five categories to choose from; personal, health, dietary, exercise, and travel. 
This is an API using Entity Framework. 

3 Features used are: 
1. Project is an CRUD API, 
2. Application is asynchronus, 
3. Created a dictionary/list, populated it with several values, retrieved at least one value, and used it in my program.

A Health journal type that can be used the record entries that you may want to share with your healthcare provider. 
A Dietary journal to help track your eating habits and meals. 
A Travel journal type that you can record you travels and cross country adventures! 
A Personal Journal for normal Journaling. 
An Exercise Journal to keep track of your Workout Sessions.

You will need to provide a unique ID for each of the payload GUID. Go to guidgenerator.com
For the date, your local will generate the current date or enter a custom date using the date format shown in each payload.

Create your own Payload on swagger or try these pre-made payloads.

DIETARIES
  "id": "Go to guidgenerator.com",
  "date": "YYYY-MM-DD",
  "notes": "Ready for my new diet! maximum 2100 calories a day. Here we go!",
  "breakfast": "Apple Cinnamon Oatmeal with OJ",
  "lunch": "Turkey Club Wrap with Apple Slices. Green Tea",
  "dinner": "(0z Filet Mignon, Sauteed Green Beans, Herb Roasted Potates",
  "desert": "Creme Brulee with Fresh Strawberries",
  "snacks": "Trail Mix",
  "totalCalories": 1750,
  "totalCarbohydrates": 15,
  "totalProtien": 32

EXERCISE
  "id": "Go to guidgenerator.com",
  "date": "YYYY-MM-DD",
  "notes": "Don't forget to log steps and reps",
  "workOutType": "Cardio 2-mile run",
  "duration": "25 mins"

HEALTH
  "id": "Go to guidgenerator.com",
  "date": "YYYY-MM-DD",
  "notes": "Having abdominal pain post surgery. have had multiple procedures. I need a resolution. Now!",
  "healthIssue": "Female abdominal pain",
  "description": "Had a procedure to eliminate pain, pain started again in lower abdomen",
  "physician": "Dr.Pepper"

JOURNAL
  "id": "Go to guidgenerator.com",
  "date": "YYYY-MM-DD",
  "notes": "Lets get ready to Journal! This is just the begining. i cant wait to share my history and organize things that matter to me."

PERSONAL
  "id": "Go to guidgenerator.com",
  "date": "YYYY-MM-DD",
  "notes": "I just started my new job as a software developer for SAMSUNG. I would like to say its 100% remote. I can work anywhere in the world!",
  "entryTitle": "Best Day Ever"

TRAVEL
  "id": "Go to guidgenerator.com",
  "date": "YYYY-MM-DD",
  "notes": "I LOVE BEING A DIGITAL NOMAD!!",
  "destination": "ONTARIO, CANADA",
  "duration": "2 WEEKS"




