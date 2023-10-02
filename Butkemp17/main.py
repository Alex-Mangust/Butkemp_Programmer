from flask import Flask, render_template

app = Flask(__name__)

@app.route('/')
def main():
    names = ["Викула", "Роман", "Анастасия Ф.", 
             "Александр Х.", "Дмитрий", "Александр",
             "Антон", "Михаил", "Анастасия С.", 
             "Алексей В.", "Алексей Б.",
             "Алексей Л.",
             "Александра"] #list(список)
    return render_template('base.html', 
                           title="Butkemp17",
                           names=names)

@app.route("/students")
def students():
    names = ["Викула", "Роман", "Анастасия Ф.", 
             "Александр Х.", "Дмитрий", "Александр",
             "Антон", "Михаил", "Анастасия С.", 
             "Алексей В.", "Алексей Б.",
             "Алексей Л.",
             "Александра"] #list(список)
    return render_template("students.html",
                           title = "Список всех студентов",
                           names=names)
if __name__ == '__main__':
    app.run()
