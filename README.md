EquipTrackAI - מדריך למשתמש
הקדמה

פרויקט EquipTrackAI פותח במסגרת פרויקט גמר, במטרה לספק מערכת חכמה לניהול ציוד ומשימות. המערכת מאפשרת למשתמש לבצע מגוון פעולות כגון: הקצאת ציוד, ניהול חיילים, עריכת משימות, גריטת פריטים, צפייה בדוחות ועוד, באמצעות ממשק גרפי נוח וגמיש הנתמך בבינה מלאכותית לעיבוד שפה טבעית בעברית.
המערכת מבוססת על ארכיטקטורת שרת-לקוח, ופועלת גם בסביבות מנותקות רשת. דגש מיוחד הושם על חוויית משתמש, נגישות ואבטחת מידע.

הוראות התקנה והרצה

1. יש לוודא כי במחשב מותקן .NET 6.0 ומעלה.
2. יש להוריד את קבצי הפרויקט מהרפוזיטורי (כולל תיקיות Server ו-client).
3. יש לפתוח את קובץ הפתרון (Tikshuv.sln או TikshuvServer.sln) באמצעות Visual Studio.
4. יש לקמפל את הפתרון (Build Solution).
5. ניתן להריץ את המערכת מתוך Visual Studio (F5) או להריץ את קובץ ההרצה מתוך התיקיה bin/Debug.

תיאור מסכי המערכת וכפתורים עיקריים
1. מסך התחברות

- שם משתמש וסיסמה: מאפשרים כניסה למערכת בהתאם להרשאות.
- כפתור התחבר: מאמת את הנתונים ומעביר את המשתמש למסך הראשי.

2. מסך ראשי

- ניהול ציוד: מעבר למסך מחסן עם אפשרויות חיפוש, הוספה, גריטה ועריכה של פריטי ציוד.
- ניהול משימות: פתיחה או עריכה של משימות קיימות, שיוך ציוד וחיילים למשימה.
- ניהול חיילים: הצגה, הוספה ועריכה של פרטי חיילים.
- הגדרות: עדכון פרטי מערכת ונתוני קונפיגורציה.
- דוחות: צפייה וייצוא של היסטוריית פריטים ופעולות.

3. מסך ניהול ציוד

- הוסף פריט חדש: יצירת פריט חדש לפי תבנית קיימת.
- גרוטת ציוד: מחיקת ציוד מהמלאי באופן קבוע.
- עריכת תבנית: עדכון מאפייני סוג ציוד (שדות, תוספות וכו').
- איתור ציוד: חיפוש לפי סוג, משימה או מזהה.

4. מסך ניהול משימות

- צור משימה: פתיחת משימה חדשה.
- עדכון משימה: שינוי משימה קיימת, כולל שיוך פריטים.
- שיוך ציוד: בחירה בפריטים מתוך המחסן עבור המשימה.

5. הגדרות

- ניהול משתמשים: הצגת כלל המשתמשים.
- שינוי סיסמה: עדכון פרטי התחברות.
- קונפיגורציות כלליות: נתונים מערכתיים.

6. שרת

תיקיית השרת כוללת את הקבצים האחראים על תקשורת הנתונים, ניהול מסדי נתונים וקבלת הבקשות מהלקוח. 
יש לוודא שהשרת מופעל לפני פתיחת הלקוח.


EquipTrackAI - User Guide
Introduction

The EquipTrackAI project was developed as part of a final project, with the aim of providing a smart system for managing equipment and tasks. The system allows the user to perform a variety of operations such as: allocating equipment, managing soldiers, editing tasks, scraping items, viewing reports and more, using a convenient and flexible graphical interface supported by artificial intelligence for natural language processing in Hebrew.
The system is based on a client-server architecture, and also operates in disconnected environments. Special emphasis was placed on user experience, accessibility and information security.

Installation and running instructions

1. Make sure that .NET 6.0 or higher is installed on the computer.
2. Download the project files from the repository (including Server and client folders).
3. Open the solution file (Tikshuv.sln or TikshuvServer.sln) using Visual Studio.
4. Compile the solution (Build Solution).
5. The system can be run from Visual Studio (F5) or the executable file can be run from the bin/Debug folder.

Description of the system screens and main buttons

1. Login screen

- Username and password: Enables login to the system according to permissions.

- Login button: Validates the data and transfers the user to the main screen.

2. Main screen

- Equipment management: Go to the warehouse screen with options to search, add, scrape and edit equipment items.

- Task management: Open or edit existing tasks, associate equipment and soldiers to a task.

- Soldier management: View, add and edit soldier details.

- Settings: Update system details and configuration data.

- Reports: View and export item and action history.

3. Equipment management screen

- Add new item: Create a new item according to an existing template.

- Scrap equipment: Permanently delete equipment from the inventory.
- Edit Template: Update equipment type properties (fields, extensions, etc.).
- Find Equipment: Search by type, task, or ID.

4. Task Management Screen

- Create Task: Open a new task.
- Update Task: Modify an existing task, including associating items.
- Associate Equipment: Select items from the warehouse for the task.

5. Settings

- User Management: View all users.
- Change Password: Update login information.
- General Configurations: System data.

6. Server

The server folder includes the files responsible for data communication, database management, and receiving requests from the client.
Make sure the server is running before opening the client.

