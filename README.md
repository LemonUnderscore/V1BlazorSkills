# Skills Matrix

The Skills Matrix is a web application to compile and mapping the skills of a group of employees. 
Their skills are represented on a detailed list, which showcases whether each employee has proficiency in each one. This allows team leaders and managers to get an overall view of the skills available on their team. The Skills Matrix’s  profiles also counts with each name, role, contact information, certificates and a brief introduction of each user.   
And now it counts with a Teams section that employees can be sorted in their respective team.

<!-- The live website can be found at [Skills Matrix](https://..../).

![responsive](/screenshot/overall.png) -->

#
## Features

### Log-in page

The Log in page contains an OAuth 2.0 authorization protocol as we are not interacting with user credentials and to supply the authorization workflow.


![loginpage](/screenshot/login.png)

### Home Section

The Home section is a Dashboard with a side nav bar that counts with Home, Teams, Employees and Teams a validated searching input that requires a text entry to run through the user database and returns what is being searched.

![home](/screenshot/home.png)

### Teams Section

- The teams section is where teams can be created, and existing user being assigned. Teams can be either deleted or edited depending on the user permission.
- A list of each team is displayed with its respective id, name and members.


![profile](/screenshot/teams.png)

### Employees Section

- The employees section contains the main details of the profile owner with their respective name, skills, contact information, an edit and a delete profile option. 
- An "About me" section with summary of description of who they are and what they do. It can mainly be used to show prospective employers, clients, and colleagues what they do and what they’ve accomplished.

![profile](/screenshot/employees.png)

### Skills Section

- The skills section is where the skills database is displayed, each with the option to sort between users based on their proficiencies.
- For each skill there is an id, skill name, and category, that can be amongst "Maths, science and engineering", "Soft skills (& civic competence)", "Digital competence" and "Entrepreneurship (Business)".
- As the previews sections each item displayed can be either deleted or edited depending on the user permission.

![profile](/screenshot/skills.png)


#


## Testing

* Users should be able to login with a valid ID and Password.

* Users should not log in with an invalid ID and Password, and the software should show them the correct error message.

* Border conditions like blank ID or Password checked.

* Other links on the page like Remember me, Forgot password should take the user to the right pages.

* Users should be able add new users.

* Users should not be able to delete users.

* The page was tested in Chrome, Opera and Firefox (mobile and desktop versions).

* It was confirmed that this project is fully responsive on all screen sizes using dev tools.

* It was confirmed by testing with users that the text of all sections is readable and understandable.

* It was confirmed that the Employees input requires entry, and the "Save changes" button works.

* It was confirmed that the Teams input requires entry, and the "Save changes" button works.

* It was confirmed that the Skills input requires entry, and the "Save changes" button works.


#



## Futures improvements?

- Add a searching and category sorting functionality
- Create Dark mode.
- Creating a profile view for the employees



