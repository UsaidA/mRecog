using mRecog.Application.Common.Mappings;
using mRecog.Domain.Entities;

namespace mRecog.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
