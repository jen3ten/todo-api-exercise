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
                    <div class="delete-todo">
                        <h3>${todo.item}</h3>
                        <input class="delete-todo__id" type="hidden" value="${todo}">
                        <button class="delete-todo__submit">delete</button>
                    </div>
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
