# react-pager

<Pager
    total={this.state.total}
    current={this.state.current}
    visiblePages={this.state.visiblePage}
    titles={{ first: '<|', last: '>|' }}
    className="pagination-sm pull-right"
    onPageChanged={this.handlePageChanged}
/>

const list = Object.keys(this.state.inputTypeList).filter(q => q != index");