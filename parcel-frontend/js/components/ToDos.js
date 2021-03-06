import imgTodo from "~/img/img_todo.jpg";

export default function ToDo(todos) {
  console.log(todos);
  return `
        <img src=${imgTodo}>
        <ol>
            ${todos
              .map(todo => {
                return `
                <li>
                    <h3>${todo.item}</h3>
                    ${todo.tags
                      .map(tagitem => {
                        return `
                            <h4>${tagitem.name}</h4>
                        `;
                      })
                      .join("")}
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
