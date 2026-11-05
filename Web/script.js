const taskForm = document.getElementById("task-form");
const taskInput = document.getElementById("task-input");
const taskList = document.getElementById("task-list");

taskForm.addEventListener("submit", function (event) {
    event.preventDefault();

    const taskName = taskInput.value.trim();

    if (taskName === "") {
        return;
    }

    const taskItem = document.createElement("li");
    taskItem.className = "task-card";
    taskItem.textContent = taskName;
    taskList.appendChild(taskItem);

    taskInput.value = "";
    taskInput.focus();
});
