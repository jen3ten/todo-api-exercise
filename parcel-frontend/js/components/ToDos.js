import imgTodo from "~/img/img_todo.jpg";

export default function ToDo(todos) {
  return `
        <ol>
            ${todos
              .map(todo => {
                return `
                <li>
                    <h3>${todo.item}</h3>
                    <img src=${imTodo}>
                </li>
                `;
              })
              .join("")}
        </ol>

        <section class="add-todo">
            <input class="add-todo__todoname" type="text" placeholder="Add a todo!">
            <button class="add-todo__submit">Submit</button>
        </section>
    `;
}
